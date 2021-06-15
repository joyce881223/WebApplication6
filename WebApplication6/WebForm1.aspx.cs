using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void drinks_SelectedIndexChanged1(object sender, EventArgs e)
        {
            other.Items.Clear();
            if (drinks.SelectedValue == "綠茶")
            {
                other.Items.Add(new ListItem("珍珠", "珍珠"));
                other.Items.Add(new ListItem("椰果", "椰果"));
                other.Items.Add(new ListItem("仙草", "仙草"));
                other.Items.Add(new ListItem("無須加料", "無須加料"));
            }
            else if (drinks.SelectedValue == "紅茶")
            {
                
                other.Items.Add(new ListItem("果凍", "果凍"));
                other.Items.Add(new ListItem("椰果", "椰果"));
                other.Items.Add(new ListItem("仙草", "仙草"));
                other.Items.Add(new ListItem("無須加料", "無須加料"));
            }
            else if (drinks.SelectedValue == "奶茶")
            {
                other.Items.Add(new ListItem("限定料-芋圓", "限定料-芋圓"));
                other.Items.Add(new ListItem("布丁", "布丁"));
                other.Items.Add(new ListItem("珍珠", "珍珠"));
                other.Items.Add(new ListItem("椰果", "椰果"));
                other.Items.Add(new ListItem("仙草", "仙草"));
                other.Items.Add(new ListItem("無須加料", "無須加料"));
            }
            ice.Items.Clear();
            if(drinks.SelectedValue == "綠茶")
            {
                ice.Items.Add(new ListItem("多冰", "多冰"));
                ice.Items.Add(new ListItem("正常", "正常"));
                ice.Items.Add(new ListItem("去冰", "去冰"));
                ice.Items.Add(new ListItem("溫", "溫"));
                ice.Items.Add(new ListItem("熱", "熱"));
            }
            else if (drinks.SelectedValue == "紅茶")
            {
                ice.Items.Add(new ListItem("多冰", "多冰"));
                ice.Items.Add(new ListItem("正常", "正常"));
                ice.Items.Add(new ListItem("去冰", "去冰"));
                ice.Items.Add(new ListItem("溫", "溫"));
                ice.Items.Add(new ListItem("熱", "熱"));
            }
            else if (drinks.SelectedValue == "奶茶")
            {
                ice.Items.Add(new ListItem("多冰", "多冰"));
                ice.Items.Add(new ListItem("正常冰", "正常冰"));
                ice.Items.Add(new ListItem("去冰", "去冰"));
                ice.Items.Add(new ListItem("溫", "溫"));
                ice.Items.Add(new ListItem("熱", "熱"));
            }
            sugar.Items.Clear();
            if(drinks.SelectedValue == "綠茶")
            {
                sugar.Items.Add(new ListItem("多糖", "多糖"));
                sugar.Items.Add(new ListItem("正常糖", "正常糖"));
                sugar.Items.Add(new ListItem("微糖", "微糖"));
                sugar.Items.Add(new ListItem("無糖", "無糖"));
            }
            else if (drinks.SelectedValue == "紅茶")
            {
                sugar.Items.Add(new ListItem("多糖", "多糖"));
                sugar.Items.Add(new ListItem("正常", "正常"));
                sugar.Items.Add(new ListItem("微糖", "微糖"));
                sugar.Items.Add(new ListItem("無糖", "無糖"));
            }
            else if (drinks.SelectedValue == "奶茶")
            {
                sugar.Items.Add(new ListItem("多糖", "多糖"));
                sugar.Items.Add(new ListItem("正常", "正常"));
                sugar.Items.Add(new ListItem("微糖", "微糖"));
                sugar.Items.Add(new ListItem("無糖", "無糖"));
            }
        }
        protected void tbx_Number_TextChanged(object sender, EventArgs e)
        {
            lb_Txt.Text = tbx_Number.Text + " " + "選擇" + drinks.Text + "+" + other.Text + " " + ice.Text + sugar.Text;
        }
    }
}