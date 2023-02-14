using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication27
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SName"]!=null)
                Label1.Text = Session["SName"].ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SetImageUrl();
        }
        IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
        {
            List<int> candidates = new List<int>();
            for (int i = minInclusive; i <= maxInclusive; i++)
            {
                candidates.Add(i);
            }
            Random rnd = new Random();
            while (candidates.Count > 0)
            {
                int index = rnd.Next(candidates.Count);
                yield return candidates[index];
                candidates.RemoveAt(index);
            }
        }

        private void SetImageUrl()
        {


            foreach (int i in UniqueRandom(1, 4))

            Image1.ImageUrl = "~/images/" + i.ToString() + ".jpg";
        }
    }
}