using VubCaffe.Models.Products.Drinks.Beverages;
using VubCaffe.Models.Products.Drinks.Coffees;
using VubCaffe.Models.Products.Sweets;
using VubCaffe.Models.Products;
using VubCaffe.Models;

namespace VubCaffe;

public partial class FormMain : Form
{
    private Bill currentBill;

    public FormMain()
    {
        InitializeComponent();
        InitializeNewBill();
    }

    private void InitializeNewBill()
    {
        currentBill = new Bill();
        lbItems.Items.Clear();
        UpdateTotalDisplay();
    }

    private void AddProductToBill(IProduct product)
    {
        currentBill.AddItem(product);
        lbItems.Items.Add(product.GetBillEntry());
        UpdateTotalDisplay();
    }

    private void UpdateTotalDisplay()
    {
        lblTotalPrice.Text = $"{currentBill.GetTotalPrice():F2} EUR";
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Jeste li sigurni da zelite izaci iz programa?", "Izlaz iz programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            Close();
        }
    }

    // Coffee Buttons
    private void btnEspresso_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Espresso());
    }

    private void btnCappucino_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Cappuccino());
    }

    private void btnLatte_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Latte());
    }

    // Beverage Buttons
    private void btnCocaCola_Click(object sender, EventArgs e)
    {
        AddProductToBill(new CocaCola());
    }

    private void btnSprite_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Sprite());
    }

    private void btnFanta_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Fanta());
    }

    // Sweets Buttons
    private void btnIceCream_Click(object sender, EventArgs e)
    {
        AddProductToBill(new IceCream());
    }

    private void btnCake_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Cake());
    }

    // Voucher Buttons
    private void btnVoucher100Eur_Click(object sender, EventArgs e)
    {
        AddProductToBill(new Voucher("Poklon bon 100 EUR", 100.00));
    }

    // Bill Management Buttons
    private void btnNewBill_Click(object sender, EventArgs e)
    {
        InitializeNewBill();
        MessageBox.Show("Novi racun je kreiran.", "Novi racun", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBill_Click(object sender, EventArgs e)
    {
        if (currentBill.IsEmpty())
        {
            MessageBox.Show("Racun je prazan. Dodajte proizvode prije naplate.", "Naplata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            MessageBox.Show($"Ukupan iznos za naplatu: {currentBill.GetTotalPrice():F2} EUR", "Naplata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeNewBill();
        }
    }
}