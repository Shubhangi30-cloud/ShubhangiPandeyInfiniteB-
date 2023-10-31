using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the initial selection of the dropdown list
                ddlItems.SelectedIndex = 0;
                // Display the default image (you can set this in the markup as well)
                imgItem.ImageUrl = "~/Images/default.jpg";
            }
        }

        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the image URL based on the selected item
            string selectedImageUrl = ddlItems.SelectedValue;
            imgItem.ImageUrl = $"~/Images/{selectedImageUrl}";
            lblCost.Text = ""; // Clear the cost label.
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            string selectedItem = ddlItems.SelectedValue;

            // Define a dictionary of item costs (you can use a database in a real application).
            var itemCosts = new Dictionary<string, decimal>
            {
                { "DairyMilk.jpg", 200.00m },
                { "Kitkat.jpg", 150.00m },
                { "Munch.jpg", 100.00m },
                { "Perk.jpg", 120.00m },
                {"5 Star.jpg", 20.00m },
            };

            if (itemCosts.ContainsKey(selectedItem))
            {
                lblCost.Text = $"Cost: ${itemCosts[selectedItem]}";
            }
            else
            {
                lblCost.Text = "Cost not available.";
            }
        }
    }
}
