using DevExpress.Diagram.Core;
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

            foreach (Link link in diag.Connections)
            {
                //ShapeDescription desc = new ShapeDescription()
                ////DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100);
                ////diagramItem1.Shape.Id = link.Item1.Id;
                ////diagramItem1.Shape.Id = link.Item1.Id;

                //DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100);
                //DiagramConnector connector1 = new DiagramConnector(diagramItem1, diagramItem2);


            }

            
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
            for (int i = 0; i < 5; i++)
                Items.Add(new Item { Id = i, Name = "Item " + i });
            Connections = new List<Link>();
            var rand = new Random();
            for (int i = 0; i < 5; i++)
                Connections.Add(new Link { Item1 = Items[rand.Next(0, Items.Count - 1)], Item2 = Items[rand.Next(0, Items.Count - 1)] });
            Groups = new List<Group>();
            for (int i = 0; i < 10; i++)
                Groups.Add(new Group() { Name = "Group " + i });
            foreach (var item in Items)
                Groups[rand.Next(0, Groups.Count)].Items.Add(item);
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
