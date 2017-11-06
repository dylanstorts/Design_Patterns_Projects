using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Composite OfficeBuilding = new Composite(1, "building");

        private Leaf MakeOffice(int officeNum, int floorNum)
        {
            Leaf newOffice = new Leaf();

            switch (floorNum)
            {
                case 1:
                    //here if floor one
                    switch (officeNum)
                    {
                        case 1:
                            //newOffice.SetLeaf(officeNum, "Sheri", "Secratary");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Sheri";
                            newOffice.PersonTitle = "Secretary";
                            break;
                        case 2:
                            //newOffice.SetLeaf(officeNum, "Mark", "Secratary");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Mark";
                            newOffice.PersonTitle = "Secretary";
                            break;
                        case 3:
                            //newOffice.SetLeaf(officeNum, "Danna", "Secratary");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Danna";
                            newOffice.PersonTitle = "Secretary";
                            break;
                    }
                    break;
                case 2:
                    //here if floor two
                    switch (officeNum)
                    {
                        case 1:
                            //newOffice.SetLeaf(officeNum, "Dave", "Analyst");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Dave";
                            newOffice.PersonTitle = "Analyst";
                            break;
                        case 2:
                            //newOffice.SetLeaf(officeNum, "Tim", "Analyst");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Tim";
                            newOffice.PersonTitle = "Analyst";
                            break;
                        case 3:
                            //newOffice.SetLeaf(officeNum, "Arthur", "Financialist");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Arthur";
                            newOffice.PersonTitle = "Financialist";
                            break;
                    }
                    break;
                case 3:
                    //here if floor three
                    switch (officeNum)
                    {
                        case 1:
                            //newOffice.SetLeaf(officeNum, "Dylan", "C.E.O.");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Dylan";
                            newOffice.PersonTitle = "C.E.O.";
                            break;
                        case 2:
                            //newOffice.SetLeaf(officeNum, "Veronica", "Executive");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Veronica";
                            newOffice.PersonTitle = "Executive";
                            break;
                        case 3:
                            //newOffice.SetLeaf(officeNum, "Zack", "Executive");
                            newOffice.OfficeNum = officeNum;
                            newOffice.PersonName = "Zack";
                            newOffice.PersonTitle = "Executive";
                            break;
                    }
                    break;
            }

            return newOffice;
        }

        public void GenerateOfficeBuilding()
        {
            for(int i = 1; i < 4; i++)
            {
                Composite floor = new Composite(i, "floor");

                for (int j = 1; j < 4; j++)
                {
                    Leaf newOffice = MakeOffice(j, i);

                    floor.Add(newOffice);
                }

                OfficeBuilding.Add(floor);
            }
        }

        public string GetBuildingInfo()
        {
            GenerateOfficeBuilding();

            return OfficeBuilding.Operation();
        }

        private void btn_generateBuilding_Click(object sender, EventArgs e)
        {
            txtb_buildingInfo.Text = GetBuildingInfo();
        }
    }
}
