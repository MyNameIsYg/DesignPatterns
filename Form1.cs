using System.Windows.Forms;
using DesignPatterns.Builder;
using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.State;

namespace DesignPatterns;

public partial class Form1 : Form
{
    string
    VendingMachine machine;
    IMachineState currentState;
    float price;
    float balance;
    CashPayment cashPayment;
    public Form1()
    {
        InitializeComponent();
        machine = new VendingMachine();
        currentState = new StartOrderState();
        MyMesseg.Text = currentState.ProcessOrder(this);
        price = 0;
        balance = 0;
    }

    private void InviteBtn_Click(object sender, EventArgs e)
    {
        Product product;
        GiftWarpDecorator giftWarpDecorator = null;
        BagDecorator bagDecorator = null;

        string selectName = ProductsList.SelectedItem.ToString();
        product = new Product() { NameProduct = selectName };
        foreach (var item in machine.inventory)
        {
            if (item.Key.NameProduct == selectName)
            {
                product.Price = item.Key.Price;
                break;
            }
        }
        product.AddProductToFile();

        machine.UpdateInventory(product);

        if (BagCheck.Checked)
        {
            bagDecorator = new BagDecorator(product);
            if (GiftCheck.Checked)
            {
                giftWarpDecorator = new GiftWarpDecorator(bagDecorator);
            }
        }
        else if(GiftCheck.Checked)
        {
            giftWarpDecorator = new GiftWarpDecorator(product);
        }

        if (giftWarpDecorator != null)
        {
            price = giftWarpDecorator.GetCost();
        }
        else if (bagDecorator != null)
        {
            price = bagDecorator.GetCost();
        }
        else
        {
            price = product.GetCost();
        }
        ProductsList.Visible = false;
        ProductsList.ClearSelected();
        BagCheck.Checked = false;
        GiftCheck.Checked = false;
        InviteBtn.Visible = false;
        BagCheck.Visible = false;
        GiftCheck.Visible = false;
        ProductsTxt.Visible = false;
        PaymentTxt.Visible = true;
        PaymentList.Visible = true;
        PaymentTxt.Text = price.ToString();
        MyMesseg.Text = PayOrder();
        
    }

    private void PaymentList_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedIndex = PaymentList.SelectedIndex;
        switch (selectedIndex)
        {
            case 0:
                {
                    cashPayment = new();
                    EnterPaymentTxt.Visible = true;
                    Enter.Visible = true; 
                    break;
                }                
            case 1:
                {
                    CarditCardPayment carditCardPayment = new();
                    CarditCardTxt.Visible = true;
                    textBox4.Visible = true;    
                    CarditCardTxt.Text = "Place a card";
                    Task.Delay(1000).Wait();
                    carditCardPayment.ProcessPayment();
                    ChangeState();
                    break;
                }
        }
        
      

    }
    private void ChangeState()
    {
        MyMesseg.Text = currentState.ProcessOrder(this);
        Task.Delay(1000).Wait();
        NewOrder.Visible = true;
        MyMesseg.Visible = false;
        Enter.Visible = false;
        PayBack.Visible = false;
        Change.Visible = false;
        PaymentTxt.Visible = false;
        PayBack.Visible = false;
        CarditCardTxt.Visible = false;
        EnterPaymentTxt.Visible = false;
        textBox4.Visible = false;
        PaymentList.Visible = false;
        PaymentList.ClearSelected();
        EnterPaymentTxt.Text = "";
    }
    private void Enter_Click(object sender, EventArgs e)
    {
        float userPayment;
        userPayment = float.Parse(EnterPaymentTxt.Text);
        balance = userPayment - price;
        
        if (balance < 0)
        {
            MessageBox.Show("Not Enough Money \n Add more");
            userPayment = float.Parse(EnterPaymentTxt.Text);
            balance = userPayment - price;
              
        }
        PayBack.Visible = true;
        Change.Visible = true;
        PayBack.Text = balance.ToString();

        PaymentTxt.Visible = true;
        PayBack.Visible = true;
        Task.Delay(1000).Wait();
        cashPayment.ProcessPayment();
        ChangeState();
    }
    public void SetState(IMachineState state)
    {
        currentState = state;
    }
    public string ProcessOrder()
    {
        return currentState.ProcessOrder(this);
    }
    public string PayOrder()
    {
        return currentState.PayOrder(this);
    }
    public string CompleteOrder()
    {
        return currentState.CompleteOrder(this);
    }

    private void NewOrder_Click(object sender, EventArgs e)
    {
        
        SetState(new StartOrderState());
        MyMesseg.Text = ProcessOrder();
        NewOrder.Visible = false;
        ProductsList.Visible = true;
        GiftCheck.Visible = true;
        BagCheck.Visible = true;
        MyMesseg.Visible = true;

    }

    private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        InviteBtn.Visible = true;   
    }

    private void MyMesseg_TextChanged(object sender, EventArgs e)
    {

    }

    private void Change_TextChanged(object sender, EventArgs e)
    {

    }

    private void EnterPaymentTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void BagCheck_CheckedChanged(object sender, EventArgs e)
    {

    }
}

