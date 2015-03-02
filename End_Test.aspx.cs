using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;

public partial class End_Test : System.Web.UI.Page
{
    [Serializable]
    public class Grade
    {
       public string grade;
    }

    protected override void OnPreInit(EventArgs e)
    {
        PreInit += new EventHandler(Page_PreInit);
        Load += new EventHandler(Page_Load);

        base.OnPreInit(e);
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "Blue";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string ques_1 = (string)Session["Login"];
        if (ques_1 == "9182")
        {
            if (!Page.IsPostBack)
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Grade));
                Grade g = new Grade();
                using (Stream fStream = new FileStream(Server.MapPath("~/Grade.xml"), FileMode.Open))
                {
                    g = (Grade)xmlSerializer.Deserialize(fStream);
                    Label3.Text = g.grade;
                    
                }
            }
        }
        
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Grade g = new Grade();
        g.grade = TextBox1.Text;
        Label3.Text = g.grade;
        SaveAsXmlFormat(g, Server.MapPath("~/Grade.xml"));
    }
    
   
    static void SaveAsXmlFormat(object objGraph, string fileName)
    {
        try
        {

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Grade));

            using (Stream fStream = new FileStream(fileName,
              FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
        }
        catch (IOException)
        {
        }

    }

   
}