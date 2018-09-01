using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using System.Linq;

namespace BISolver
{
    public partial class Form1 : Form
    {
        private static string xivapi = "https://api.xivdb.com/";
        private static HttpClient client = new HttpClient();
        private static List<Jobs> jobList = new List<Jobs>();
        string jobID;
        string[] attr = {"Critical Hit", "Determination", "Skill Speed","Spell Speed","Tenacity","Direct Hit Rate"};
        public Form1()
        {
            InitializeComponent();
            var jobs = JArray.Parse(client.GetStringAsync(new Uri(xivapi + "data/classjobs")).Result);
            foreach (var obj in jobs)
            {
                if((int)obj.SelectToken("id") >18)
                {
                    jobList.Add(new Jobs() {
                        JobName = (string)obj.SelectToken("name_en"),
                        JobID = (string)obj.SelectToken("id"),
                        JobAbbr = (string)obj.SelectToken("abbr_en")
                    });

                }
            }

            foreach (var obj in jobList)
            {
                cmbJob.Items.Add(obj.JobName);
            }
            cmbAttr.Items.AddRange(attr);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstStats.Items.Clear();
            string miniLvl = numMinLvl.Text;
            string maxiLvl = numMaxLvl.Text;
            string mainAttr = cmbAttr.Text;
            foreach (var j in jobList)
            {
                if(cmbJob.Text == j.JobName)
                {
                    jobID = j.JobID;
                    break;
                }
            }
            string searchQuery = "search?one=items&level_item|gt=" + miniLvl + "&level_item|lt=" + maxiLvl+ "&classjobs=" + jobID + "order_field=level_item";
            var search = BuildQuery(searchQuery).SelectToken("items").SelectToken("results");
            List<Gear> gear = new List<Gear>();
            foreach (var r in search)
            {
                string itemQuery = "item/" + r.SelectToken("id") + "/" + r.SelectToken("name");
                var itemResult = BuildQuery(itemQuery);
                List<Attributes_params> attr = new List<Attributes_params>();
                foreach (var a in itemResult.SelectToken("attributes_params"))
                {
                    attr.Add(new Attributes_params() {
                        AttID = (string)a.SelectToken("id"),
                        AttName = (string)a.SelectToken("name"),
                        AttValue = (string)a.SelectToken("value"),
                        AttValueHQ = (string)a.SelectToken("value_hq")
                    });
                }
                List<Jobs> gearJobs = new List<Jobs>();
                foreach (var j in itemResult.SelectToken("classjobs"))
                {
                    gearJobs.Add(new Jobs() {
                        JobID = (string)j.SelectToken("id"),
                        JobName = (string)j.SelectToken("name"),
                        JobAbbr = (string)j.SelectToken("abbr")
                    });
                }
                gear.Add(new Gear()
                {
                    GearID = (string)itemResult.SelectToken("id"),
                    GearIcon = (string)itemResult.SelectToken("icon"),
                    GearName = (string)itemResult.SelectToken("name"),
                    GearLevel_item = (string)itemResult.SelectToken("level_item"),
                    GearCategory_name = (string)itemResult.SelectToken("category_name"),
                    GearKind_name = (string)itemResult.SelectToken("kind_name"),
                    GearMateria_slot = (string)itemResult.SelectToken("materia_slots_count"),
                    GearAttr = attr,
                    GearClassJobs = gearJobs
                });

            }
            RecommGear(mainAttr, gear);
        }
        private JObject BuildQuery(string query)
        {
            JObject result = JObject.Parse(client.GetStringAsync(new Uri(xivapi + query)).Result);
            return result;
        }
        private List<Gear> RecommGear(string mainAttr,List<Gear> gear)
        {
            int[] highest = new int[12];
            Gear weapon = new Gear();
            Gear head = new Gear();
            Gear body = new Gear();
            Gear hands = new Gear();
            Gear waist  = new Gear();
            Gear legs = new Gear();
            Gear feet = new Gear();
            Gear off = new Gear();
            Gear necklace = new Gear();
            Gear earrings = new Gear();
            Gear bracelet = new Gear();
            Gear ring1 = new Gear();
            Gear ring2 = new Gear();
            foreach (var g in gear)
            {

                if(g.GearCategory_name == "Head")
                {
                    Tuple<int,Gear> t = SetGear(mainAttr, g, head, highest[0]);
                    head = t.Item2;
                    highest[0] = t.Item1;
                }
                if (g.GearCategory_name == "Body")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, body, highest[1]);
                    body = t.Item2;
                    highest[1] = t.Item1;

                }
                if (g.GearCategory_name == "Hands")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, hands, highest[2]);
                    hands = t.Item2;
                    highest[2] = t.Item1;
                }
                if (g.GearCategory_name == "Waist")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, waist, highest[3]);
                    waist = t.Item2;
                    highest[3] = t.Item1;
                }
                if (g.GearCategory_name == "Legs")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, legs, highest[4]);
                    legs = t.Item2;
                    highest[4] = t.Item1;
                }
                if (g.GearCategory_name == "Feet")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, feet, highest[5]);
                    feet = t.Item2;
                    highest[5] = t.Item1;
                }
                if (g.GearCategory_name == "Earrings")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, earrings, highest[6]);
                    earrings = t.Item2;
                    highest[6] = t.Item1;
                }
                if (g.GearCategory_name == "Necklace")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, necklace, highest[7]);
                    necklace = t.Item2;
                    highest[7] = t.Item1;
                }
                if (g.GearCategory_name == "Bracelets")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, bracelet, highest[8]);
                    bracelet = t.Item2;
                    highest[8] = t.Item1;
                }
                if (g.GearCategory_name == "Ring")
                {
                    int value = FindHighest(mainAttr, g);
                    if ((highest[9] <= value) || (ring1 is null))
                    {
                        if (ring1.GearName is null)
                        {
                            ring1 = g;
                        }
                        else
                        {
                            ring2 = ring1;
                            ring1 = g;
                            highest[9] = value;
                        }
                    }
                }
                if (g.GearKind_name== "Arms")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, weapon, highest[10]);
                    weapon = t.Item2;
                    highest[10] = t.Item1;
                }
                if (g.GearCategory_name == "Shield")
                {
                    Tuple<int, Gear> t = SetGear(mainAttr, g, off, highest[11]);
                    off = t.Item2;
                    highest[11] = t.Item1;
                }
            }
            List<Gear> gearList = new List<Gear>() { weapon, off, head, body, hands, waist, legs, feet, necklace, earrings, bracelet, ring1, ring2 };
            int[] skills = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            foreach (Gear g in gearList)
            {
                if (g.GearName != null)
                {
                    foreach (Attributes_params a in g.GearAttr)
                    {
                        switch (a.AttName)
                        {
                            case "Critical Hit":
                                skills[0] += CalcSkills(a);
                                break;
                            case "Direct Hit Rate":
                                skills[1] += CalcSkills(a);
                                break;
                            case "Determination":
                                skills[2] += CalcSkills(a);
                                break;
                            case "Skill Speed":
                                skills[3] += CalcSkills(a);
                                break;
                            case "Spell Speed":
                                skills[4] += CalcSkills(a);
                                break;
                            case "Piety":
                                skills[5] += CalcSkills(a);
                                break;
                            case "Tenacity":
                                skills[6] += CalcSkills(a);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            pctWeapon.ImageLocation = (weapon.GearIcon);
            pctOH.ImageLocation = (off.GearIcon);
            pctHead.ImageLocation = (head.GearIcon);
            pctBody.ImageLocation = (body.GearIcon);
            pctHands.ImageLocation = (hands.GearIcon);
            pctWaist.ImageLocation = (waist.GearIcon);
            pctLegs.ImageLocation = (legs.GearIcon);
            pctFeet.ImageLocation = (feet.GearIcon);
            pctEarrings.ImageLocation = (earrings.GearIcon);
            pctNecklace.ImageLocation = (necklace.GearIcon);
            pctBracelet.ImageLocation = (bracelet.GearIcon);
            pctRing1.ImageLocation = (ring1.GearIcon);
            pctRing2.ImageLocation = (ring2.GearIcon);
            lstResult.Items.Clear();
            lstStats.Items.Add("Critical Hit: " + skills[0]);
            lstStats.Items.Add("Direct Hit Rate: " + skills[1]);
            lstStats.Items.Add("Determination: " + skills[2]);
            lstStats.Items.Add("Skill Speed: " + skills[3]);
            lstStats.Items.Add("Spell Speed: " + skills[4]);
            lstStats.Items.Add("Piety: " + skills[5]);
            lstStats.Items.Add("Tenacity: " + skills[6]);
            List<Stats> stats = new List<Stats>();
            foreach (var gl in gearList)
            {
                if(gl.GearID != null)
                {
                    lstResult.Items.Add(gl.GearCategory_name + " - " + gl.GearName);
                }
            }

            return gearList;            
        }
        private int FindHighest(string mainAttr, Gear gear)
        {
            int value = 0;
            foreach (var a in gear.GearAttr)
            {
                if (a.AttName == mainAttr)
                {
                    if (a.AttValueHQ == "0")
                    {
                        value = Convert.ToInt16(a.AttValue);
                    }
                    else
                    {
                        value = Convert.ToInt16(a.AttValueHQ);
                    }
                }
            }
            return value;
        }
        private Tuple<int,Gear> SetGear(string mainAttr, Gear gear, Gear category, int highest)
        {
            int value = FindHighest(mainAttr, gear);
            if (category.GearName is null)
            {
                category = gear;
            }
            else if (highest < value)
            {
                category = gear;
                highest = value;
            }
            return Tuple.Create(highest,category);
        }
        private int CalcSkills(Attributes_params a)
        {
            int result;
            if ((Convert.ToInt16(a.AttValueHQ) == 0) || a.AttValueHQ is null)
            {
                result = Convert.ToInt16(a.AttValue);
            }
            else
            {
                result = Convert.ToInt16(a.AttValueHQ);
            }
            return result;
        }
    }
}