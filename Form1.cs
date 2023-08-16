using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XDocument text1;
        XDocument text2;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML-файл |*.xml|All files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lable1.Text = openFileDialog1.FileName;
                text1 = XDocument.Load(lable1.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            text2 = text1;
            var root = text2.Element("documents");
            var doc313 = text2.Descendants()?.Elements("register_product_emission");
            if (doc313.Count() > 0)
            {
                var po = new XElement("posting");
                po.Add(new XAttribute("action_id", "702"));
                foreach (var node in doc313.Elements())
                {
                    po.Add(node);
                    switch (node.Name.ToString())
                    {
                        case "subject_id":
                           var xe = new XElement("shipper_info");
                            var inn1 = new XElement("inn");
                            var kpp2 = new XElement("kpp");
                            inn1.Value = inn.Text;
                            kpp2.Value = kpp.Text;
                            xe.Add(inn1);
                            xe.Add(kpp2);
                            po.Add(xe);
                            break;
                        case "release_info":
                            xe = new XElement("doc_num");
                            xe.Value = node.Element("confirmation_num").Value;
                            po.Add(xe);
                            xe = new XElement("doc_date");
                            xe.Value = node.Element("doc_date").Value;
                            po.Add(xe);
                            xe = new XElement("contract_type");
                            xe.Value = "8";
                            po.Add(xe);
                            xe = new XElement("source");
                            xe.Value = "1";
                            po.Add(xe);
                            po.Element("release_info").Remove();
                            break;
                        case "signs":
                            xe = new XElement("order_details");
                            foreach (var i1 in node.Elements("sscc"))
                            {
                               var o1 = new XElement("union");
                                o1.Add(new XElement("sscc_detail"));
                                o1.Element("sscc_detail").Add(new XElement(i1));
                                o1.Add(new XElement("cost"));
                                o1.Element("cost").Value = "0";
                                o1.Add(new XElement("vat_value"));
                                o1.Element("vat_value").Value = "0";
                                xe.Add(o1);
                            }
                            po.Add(xe);
                            po.Element("signs").Remove();
                            break;
                    }      
                }
                root.Add(po);
                doc313.Remove();
            }
            var doc431 = text2.Descendants()?.Elements("move_place");
            if (doc431.Count() >0)
            {
                var po = new XElement("posting");
                po.Add(new XAttribute("action_id", "702"));
                foreach (var node in doc431.Elements())
                {
                    po.Add(node);
                    switch (node.Name.ToString())
                    {
                        case "subject_id":
                            var xe = new XElement("shipper_info");
                            var inn1 = new XElement("inn");
                            var kpp2 = new XElement("kpp");
                            inn1.Value = inn.Text;
                            kpp2.Value = kpp.Text;
                            xe.Add(inn1);
                            xe.Add(kpp2);
                            po.Add(xe);
                            break;
                        case "receiver_id":
                            po.Element("receiver_id").Remove();
                            break;
                        case "order_details":
                            xe = new XElement("contract_type");
                            xe.Value = "8";
                            po.Add(xe);
                            xe = new XElement("source");
                            xe.Value = "1";
                            po.Add(xe);
                            xe = new XElement("order_details");
                            foreach (var i1 in node.Elements("sscc"))
                            {
                                var o1 = new XElement("union");
                                o1.Add(new XElement("sscc_detail"));
                                o1.Element("sscc_detail").Add(new XElement(i1));
                                o1.Add(new XElement("cost"));
                                o1.Element("cost").Value = "0";
                                o1.Add(new XElement("vat_value"));
                                o1.Element("vat_value").Value = "0";
                                xe.Add(o1);
                              
                            }
                            po.Element("order_details").Remove();
                            po.Add(xe);
                            break;
                    }
                }
                root.Add(po);
                doc431.Remove();
            }
            var doc415 = text2.Descendants()?.Elements("move_order");
            if (doc415.Count() > 0)
            {
                var po = new XElement("posting");
                po.Add(new XAttribute("action_id", "702"));
                foreach (var node in doc415.Elements())
                {
                    po.Add(node);
                    switch (node.Name.ToString())
                    {
                        case "subject_id":
                           var xe = new XElement("shipper_info");
                            var inn1 = new XElement("inn");
                            var kpp2 = new XElement("kpp");
                            inn1.Value = inn.Text;
                            kpp2.Value = kpp.Text;
                            xe.Add(inn1);
                            xe.Add(kpp2);
                            po.Add(xe);
                            break;
                        case "receiver_id":
                            po.Element("receiver_id").Remove();
                            break;
                        case "turnover_type":
                            po.Element("turnover_type").Remove();
                            break;
                        case "source":
                            xe = new XElement("contract_type");
                            xe.Value = "1";
                            po.Add(xe);
                            po.Element("source").Remove();
                            break;
                        case "contract_type":
                            xe = new XElement("source");
                            xe.Value = "1";
                            po.Add(xe);
                            po.Element("contract_type").Remove();
                            break;
                    }               

                }
                root.Add(po);
                doc415.Remove();
            }
            var doc416 = text2.Descendants()?.Elements("receive_order");
            if (doc416.Count() > 0)
            {
                var po = new XElement("posting");
                po.Add(new XAttribute("action_id", "702"));
                foreach (var node in doc416.Elements())
                {
                    po.Add(node);
                    switch (node.Name.ToString())
                    {
                        case "subject_id":
                            var xe = new XElement("shipper_info");
                            var inn1 = new XElement("inn");
                            var kpp2 = new XElement("kpp");
                            inn1.Value = inn.Text;
                            kpp2.Value = kpp.Text;
                            xe.Add(inn1);
                            xe.Add(kpp2);
                            po.Add(xe);
                            break;
                        case "receive_type":
                            po.Element("receive_type").Remove();
                            break;
                        case "source":
                            xe = new XElement("contract_type");
                            xe.Value = "1";
                            po.Add(xe);
                            po.Element("source").Remove();
                            break;
                        case "contract_type":
                            xe = new XElement("source");
                            xe.Value = "1";
                            po.Add(xe);
                            po.Element("contract_type").Remove();
                            break;
                    }
                }
                root.Add(po);
                doc416.Remove();
            }
            saveFileDialog1.Filter = "XML-файл |*.xml|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text2.Save(saveFileDialog1.FileName);
            }
        }
    }
}
