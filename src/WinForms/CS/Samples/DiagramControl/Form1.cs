using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Layout;
using DevExpress.XtraDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100);
            //DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 10, 200, 200, 100);
            //DiagramConnector connector1 = new DiagramConnector(diagramItem1, diagramItem2);
            //connector1.EndArrow = ArrowDescriptions.Filled90;
            //DiagramShape diagramItem3 = new DiagramShape(BasicShapes.Rectangle, 250, 10, 200, 100);
            //DiagramShape diagramItem4 = new DiagramShape(BasicShapes.Rectangle, 400, 200, 200, 100);
            //DiagramConnector connector2 = new DiagramConnector(diagramItem3, diagramItem4, new Point(350, 250));
            //connector2.EndArrow = ArrowDescriptions.Filled90;
            //diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4, connector1, connector2);


            Diagram diag = new Diagram();
            diagramControl.Items.Clear();
            List<DiagramItem> items = new List<DiagramItem>();
            Point centerPoint = new Point(diagramControl.DisplayRectangle.Width / 2, diagramControl.DisplayRectangle.Height / 2);

            int yStartPos = centerPoint.Y - ((150 * diag.Connections.Count) / 2);
            for (int index = 0; index < diag.Connections.Count; index++)
            {
                Link link = diag.Connections[index];
                DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Ellipse, centerPoint.X - 200, yStartPos + ((index + 1) * 150), 200, 100);
                diagramItem1.Content = link.Item1.Name;
                diagramItem1.Appearance.BackColor = Color.FromArgb(240, 230, 140);
                diagramItem1.Appearance.ForeColor = Color.White;
                
                    //diagramItem1.Shape.Id = link.Item1.Id;
                //diagramItem1.Shape.Id = link.Item1.Id;

                DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Ellipse, centerPoint.X + 200, yStartPos + ((index + 1) * 150), 200, 100);
                diagramItem2.Content = link.Item2.Name;
                diagramItem2.Appearance.BackColor = Color.Gray;
                diagramItem2.Appearance.ForeColor = Color.White;
                DiagramConnector connector1 = new DiagramConnector(diagramItem1, diagramItem2);
                diagramControl.Items.AddRange(diagramItem1, diagramItem2, connector1);
            }
            foreach (Link link in diag.Connections)
            {
                //ShapeDescription desc = new ShapeDescription(link.Item1.Id, link.Item1.Name, )

                   
            }
            //diagramControl.ApplySugiyamaLayout(Direction.Down);
            diagramControl.Refresh();

            //diagramDataBindingController1.DataSource = diag.Items;
            //diagramDataBindingController1.ConnectorsSource = diag.Connections;
            //diagramDataBindingController1.ConnectorFromMember = "Item1";
            //diagramDataBindingController1.ConnectorToMember = "Item2";
        }
    }


    class Diagram
    {
        public List<Item> Items { get; set; }
        public List<Link> Connections { get; set; }
        public List<Group> Groups { get; set; }
        public Diagram()
        {
            Items = new List<Item>();
            Connections = new List<Link>();
            //Create Air Loops             
            int i = 0;
            for (i = 0; i < 3; i++)
                Items.Add(new Item { Id = i + 1, Name = "Air-" + (i + 1) });

            //Create Zone HVAC Loops
            for (int j = 0; j < i; j++)
            {
                Items.Add(new Item { Id = i + j, Name = "ZHG-" + (j + 1) });
                Connections.Add(new Link { Item1 = Items[j], Item2 = Items[i + j] });
            }
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType BldgItemType { get; set; }
    }
    public class Link
    {
        public Item Item1 { get; set; }
        public Item Item2 { get; set; }
    }
    public class Group
    {
        public Group()
        {
            Items = new List<Item>();
        }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
