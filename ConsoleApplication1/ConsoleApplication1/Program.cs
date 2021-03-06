﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> nodes = new List<Node>();
            Node Alaska = new Node("Alaska");
            nodes.Add(Alaska);
            Node Alberta = new Node("Alberta");
            nodes.Add(Alberta);
            Node CentralAmerica = new Node("CentralAmerica");
            nodes.Add(CentralAmerica);
            Node EasternUnitedStates = new Node("EasternUnitedStates");
            nodes.Add(EasternUnitedStates);
            Node GreenLand = new Node("GreenLand");
            nodes.Add(GreenLand);
            Node NorthwestTerritory = new Node("NorthwestTerritory");
            nodes.Add(NorthwestTerritory);
            Node Ontario = new Node("Ontario");
            nodes.Add(Ontario);
            Node Quebec = new Node("Quebec");
            nodes.Add(Quebec);
            Node WesternUnitedStates = new Node("WesternUnitedStates");
            nodes.Add(WesternUnitedStates);
            Node Argentina = new Node("Argentina");
            nodes.Add(Argentina);
            Node Brazil = new Node("Brazil");
            nodes.Add(Brazil);
            Node Peru = new Node("Peru");
            nodes.Add(Peru);
            Node Venezuela = new Node("Venezuela");
            nodes.Add(Venezuela);
            Node GreatBritain = new Node("GreatBritain");
            nodes.Add(GreatBritain);
            Node Iceland = new Node("Iceland");
            nodes.Add(Iceland);
            Node NorthernEurope = new Node("NorthernEurope");
            nodes.Add(NorthernEurope);
            Node Scandanavia = new Node("Scandanavia");
            nodes.Add(Scandanavia);
            Node SouthernEurope = new Node("SouthernEurope");
            nodes.Add(SouthernEurope);
            Node Ukraine = new Node("Ukraine");
            nodes.Add(Ukraine);
            Node WesternEurope = new Node("WesternEurope");
            nodes.Add(WesternEurope);
            Node Congo = new Node("Congo");
            nodes.Add(Congo);
            Node EastAfrica = new Node("EastAfrica");
            nodes.Add(EastAfrica);
            Node Egypt = new Node("Egypt");
            nodes.Add(Egypt);
            Node Madagascar = new Node("Madagascar");
            nodes.Add(Madagascar);
            Node NorthAfrica = new Node("NorthAfrica");
            nodes.Add(NorthAfrica);
            Node SouthAfrica = new Node("SouthAfrica");
            nodes.Add(SouthAfrica);
            Node Afghanistan = new Node("Afghanistan");
            nodes.Add(Afghanistan);
            Node China = new Node("China");
            nodes.Add(China);
            Node India = new Node("India");
            nodes.Add(India);
            Node Irkutsk = new Node("Irkutsk");
            nodes.Add(Irkutsk);
            Node Japan = new Node("Japan");
            nodes.Add(Japan);
            Node Kamchatka = new Node("Kamchatka");
            nodes.Add(Kamchatka);
            Node MiddleEast = new Node("MiddleEast");
            nodes.Add(MiddleEast);
            Node Mongolia = new Node("Mongolia");
            nodes.Add(Mongolia);
            Node Siam = new Node("Siam");
            nodes.Add(Siam);
            Node Siberia = new Node("Siberia");
            nodes.Add(Siberia);
            Node Ural = new Node("Ural");
            nodes.Add(Ural);
            Node Yakutsk = new Node("Yakutsk");
            nodes.Add(Yakutsk);
            Node EasternAustralia = new Node("EasternAustralia");
            nodes.Add(EasternAustralia);
            Node Indonesia = new Node("Indonesia");
            nodes.Add(Indonesia);
            Node NewGuinea = new Node("NewGuinea");
            nodes.Add(NewGuinea);
            Node WesternAustralia = new Node("WesternAustralia");
            nodes.Add(WesternAustralia);
            Alaska.edges.Add(new Edge(Alaska, Kamchatka));
            Alaska.edges.Add(new Edge(Alaska, NorthwestTerritory));
            Alaska.edges.Add(new Edge(Alaska, Alberta));
            NorthwestTerritory.edges.Add(new Edge(NorthwestTerritory, Alaska));
            NorthwestTerritory.edges.Add(new Edge(NorthwestTerritory, Alberta));
            NorthwestTerritory.edges.Add(new Edge(NorthwestTerritory, Ontario));
            NorthwestTerritory.edges.Add(new Edge(NorthwestTerritory, GreenLand));
            Alberta.edges.Add(new Edge(Alberta, Alaska));
            Alberta.edges.Add(new Edge(Alberta, NorthwestTerritory));
            Alberta.edges.Add(new Edge(Alberta, Ontario));
            Alberta.edges.Add(new Edge(Alberta, WesternAustralia));
            Ontario.edges.Add(new Edge(Ontario, Alberta));
            Ontario.edges.Add(new Edge(Ontario, NorthwestTerritory));
            Ontario.edges.Add(new Edge(Ontario, Quebec));
            Ontario.edges.Add(new Edge(Ontario, WesternUnitedStates));
            Ontario.edges.Add(new Edge(Ontario, EasternUnitedStates));
            Ontario.edges.Add(new Edge(Ontario, GreenLand));
            Quebec.edges.Add(new Edge(Quebec, Ontario));
            Quebec.edges.Add(new Edge(Quebec, EasternUnitedStates));
            Quebec.edges.Add(new Edge(Quebec, GreenLand));
            GreenLand.edges.Add(new Edge(GreenLand, Ontario));
            GreenLand.edges.Add(new Edge(GreenLand, NorthwestTerritory));
            GreenLand.edges.Add(new Edge(GreenLand, Quebec));
            GreenLand.edges.Add(new Edge(GreenLand, Iceland));
            WesternUnitedStates.edges.Add(new Edge(WesternUnitedStates, Alberta));
            WesternUnitedStates.edges.Add(new Edge(WesternUnitedStates, Ontario));
            WesternUnitedStates.edges.Add(new Edge(WesternUnitedStates, EasternUnitedStates));
            WesternUnitedStates.edges.Add(new Edge(WesternUnitedStates, CentralAmerica));
            EasternUnitedStates.edges.Add(new Edge(EasternUnitedStates, WesternUnitedStates));
            EasternUnitedStates.edges.Add(new Edge(EasternUnitedStates, Quebec));
            EasternUnitedStates.edges.Add(new Edge(EasternUnitedStates, Ontario));
            EasternUnitedStates.edges.Add(new Edge(EasternUnitedStates, CentralAmerica));
            CentralAmerica.edges.Add(new Edge(CentralAmerica, WesternUnitedStates));
            CentralAmerica.edges.Add(new Edge(CentralAmerica, EasternUnitedStates));
            CentralAmerica.edges.Add(new Edge(CentralAmerica, Venezuela));
            Venezuela.edges.Add(new Edge(Venezuela, CentralAmerica));
            Venezuela.edges.Add(new Edge(Venezuela, Peru));
            Venezuela.edges.Add(new Edge(Venezuela, Brazil));
            Peru.edges.Add(new Edge(Peru, Venezuela));
            Peru.edges.Add(new Edge(Peru, Brazil));
            Peru.edges.Add(new Edge(Peru, Argentina));
            Brazil.edges.Add(new Edge(Brazil, Peru));
            Brazil.edges.Add(new Edge(Brazil, Argentina));
            Brazil.edges.Add(new Edge(Brazil, NorthAfrica));
            Argentina.edges.Add(new Edge(Argentina, Brazil));
            Argentina.edges.Add(new Edge(Argentina, Peru));
            NorthAfrica.edges.Add(new Edge(NorthAfrica, Brazil));
            NorthAfrica.edges.Add(new Edge(NorthAfrica, WesternEurope));
            NorthAfrica.edges.Add(new Edge(NorthAfrica, SouthernEurope));
            NorthAfrica.edges.Add(new Edge(NorthAfrica, Egypt));
            NorthAfrica.edges.Add(new Edge(NorthAfrica, EastAfrica));
            NorthAfrica.edges.Add(new Edge(NorthAfrica, Congo));
            Egypt.edges.Add(new Edge(Egypt, NorthAfrica));
            Egypt.edges.Add(new Edge(Egypt, SouthernEurope));
            Egypt.edges.Add(new Edge(Egypt, EastAfrica));
            Egypt.edges.Add(new Edge(Egypt, MiddleEast));
            EastAfrica.edges.Add(new Edge(EastAfrica, Egypt));
            EastAfrica.edges.Add(new Edge(EastAfrica, MiddleEast));
            EastAfrica.edges.Add(new Edge(EastAfrica, Congo));
            EastAfrica.edges.Add(new Edge(EastAfrica, SouthAfrica));
            EastAfrica.edges.Add(new Edge(EastAfrica, Madagascar));
            SouthAfrica.edges.Add(new Edge(SouthAfrica, EastAfrica));
            SouthAfrica.edges.Add(new Edge(SouthAfrica, Congo));
            SouthAfrica.edges.Add(new Edge(SouthAfrica, Madagascar));
            Madagascar.edges.Add(new Edge(Madagascar, SouthAfrica));
            Madagascar.edges.Add(new Edge(Madagascar, EastAfrica));
            Congo.edges.Add(new Edge(Congo, SouthAfrica));
            Congo.edges.Add(new Edge(Congo,EastAfrica));
            Congo.edges.Add(new Edge(Congo, NorthAfrica));
            WesternEurope.edges.Add(new Edge(WesternEurope, NorthAfrica));
            WesternEurope.edges.Add(new Edge(WesternEurope, NorthernEurope));
            WesternEurope.edges.Add(new Edge(WesternEurope, SouthernEurope));
            NorthernEurope.edges.Add(new Edge(NorthernEurope, SouthernEurope));
            NorthernEurope.edges.Add(new Edge(NorthernEurope, WesternEurope));
            NorthernEurope.edges.Add(new Edge(NorthernEurope, Ukraine));
            NorthernEurope.edges.Add(new Edge(NorthernEurope, GreatBritain));
            NorthernEurope.edges.Add(new Edge(NorthernEurope, Scandanavia));
            SouthernEurope.edges.Add(new Edge(SouthernEurope, NorthernEurope));
            SouthernEurope.edges.Add(new Edge(SouthernEurope, WesternEurope));
            SouthernEurope.edges.Add(new Edge(SouthernEurope, Ukraine));
            SouthernEurope.edges.Add(new Edge(SouthernEurope, NorthAfrica));
            SouthernEurope.edges.Add(new Edge(SouthernEurope, MiddleEast));
            SouthernEurope.edges.Add(new Edge(SouthernEurope, Egypt));
            Ukraine.edges.Add(new Edge(Ukraine, SouthernEurope));
            Ukraine.edges.Add(new Edge(Ukraine, NorthernEurope));
            Ukraine.edges.Add(new Edge(Ukraine, Scandanavia));
            Ukraine.edges.Add(new Edge(Ukraine, MiddleEast));
            Ukraine.edges.Add(new Edge(Ukraine, Afghanistan));
            Ukraine.edges.Add(new Edge(Ukraine, Ural));
            Scandanavia.edges.Add(new Edge(Scandanavia, Ukraine));
            Scandanavia.edges.Add(new Edge(Scandanavia, NorthernEurope));
            Scandanavia.edges.Add(new Edge(Scandanavia, Iceland));
            Scandanavia.edges.Add(new Edge(Scandanavia, GreatBritain));
            GreatBritain.edges.Add(new Edge(GreatBritain, Scandanavia));
            GreatBritain.edges.Add(new Edge(GreatBritain, Iceland));
            GreatBritain.edges.Add(new Edge(GreatBritain, NorthernEurope));
            Iceland.edges.Add(new Edge(Iceland, GreatBritain));
            Iceland.edges.Add(new Edge(Iceland, Scandanavia));
            Iceland.edges.Add(new Edge(Iceland, GreenLand));
            MiddleEast.edges.Add(new Edge(MiddleEast, EastAfrica));
            MiddleEast.edges.Add(new Edge(MiddleEast, Egypt));
            MiddleEast.edges.Add(new Edge(MiddleEast, Ukraine));
            MiddleEast.edges.Add(new Edge(MiddleEast, SouthernEurope));
            MiddleEast.edges.Add(new Edge(MiddleEast, Afghanistan));
            MiddleEast.edges.Add(new Edge(MiddleEast, India));
            India.edges.Add(new Edge(India, MiddleEast));
            India.edges.Add(new Edge(India, Afghanistan));
            India.edges.Add(new Edge(India, China));
            India.edges.Add(new Edge(India, Siam));
            Siam.edges.Add(new Edge(Siam, India));
            Siam.edges.Add(new Edge(Siam, China));
            Siam.edges.Add(new Edge(Siam, Indonesia));
            China.edges.Add(new Edge(China, India));
            China.edges.Add(new Edge(China, Siam));
            China.edges.Add(new Edge(China, Afghanistan));
            China.edges.Add(new Edge(China, Ural));
            China.edges.Add(new Edge(China, Siberia));
            China.edges.Add(new Edge(China, Mongolia));
            Afghanistan.edges.Add(new Edge(Afghanistan, China));
            Afghanistan.edges.Add(new Edge(Afghanistan, MiddleEast));
            Afghanistan.edges.Add(new Edge(Afghanistan, Ukraine));
            Afghanistan.edges.Add(new Edge(Afghanistan, India));
            Afghanistan.edges.Add(new Edge(Afghanistan, Ural));
            Ural.edges.Add(new Edge(Ural, Afghanistan));
            Ural.edges.Add(new Edge(Ural, Ukraine));
            Ural.edges.Add(new Edge(Ural, Siberia));
            Ural.edges.Add(new Edge(Ural, China));
            Siberia.edges.Add(new Edge(Siberia, Ural));
            Siberia.edges.Add(new Edge(Siberia, Yakutsk));
            Siberia.edges.Add(new Edge(Siberia, Irkutsk));
            Siberia.edges.Add(new Edge(Siberia, Mongolia));
            Siberia.edges.Add(new Edge(Siberia, China));
            Mongolia.edges.Add(new Edge(Mongolia, Siberia));
            Mongolia.edges.Add(new Edge(Mongolia, China));
            Mongolia.edges.Add(new Edge(Mongolia, Irkutsk));
            Mongolia.edges.Add(new Edge(Mongolia, Kamchatka));
            Mongolia.edges.Add(new Edge(Mongolia, Japan));
            Irkutsk.edges.Add(new Edge(Irkutsk, Mongolia));
            Irkutsk.edges.Add(new Edge(Irkutsk, Siberia));
            Irkutsk.edges.Add(new Edge(Irkutsk, Yakutsk));
            Irkutsk.edges.Add(new Edge(Irkutsk, Kamchatka));
            Yakutsk.edges.Add(new Edge(Yakutsk, Irkutsk));
            Yakutsk.edges.Add(new Edge(Yakutsk, Siberia));
            Yakutsk.edges.Add(new Edge(Yakutsk, Kamchatka));
            Japan.edges.Add(new Edge(Japan, Mongolia));
            Japan.edges.Add(new Edge(Japan, Kamchatka));
            Kamchatka.edges.Add(new Edge(Kamchatka, Japan));
            Kamchatka.edges.Add(new Edge(Kamchatka, Mongolia));
            Kamchatka.edges.Add(new Edge(Kamchatka, Irkutsk));
            Kamchatka.edges.Add(new Edge(Kamchatka, Yakutsk));
            Kamchatka.edges.Add(new Edge(Kamchatka, Alaska));
            Indonesia.edges.Add(new Edge(Indonesia, Siam));
            Indonesia.edges.Add(new Edge(Indonesia, NewGuinea));
            Indonesia.edges.Add(new Edge(Indonesia, WesternAustralia));
            NewGuinea.edges.Add(new Edge(NewGuinea, Indonesia));
            NewGuinea.edges.Add(new Edge(NewGuinea, WesternAustralia));
            NewGuinea.edges.Add(new Edge(NewGuinea, EasternAustralia));
            WesternAustralia.edges.Add(new Edge(WesternAustralia, EasternAustralia));
            WesternAustralia.edges.Add(new Edge(WesternAustralia, Indonesia));
            WesternAustralia.edges.Add(new Edge(WesternAustralia, NewGuinea));
            EasternAustralia.edges.Add(new Edge(EasternAustralia, WesternAustralia));
            WesternAustralia.edges.Add(new Edge(WesternAustralia, NewGuinea));

            Random r = new Random();

            Node currentNode = nodes[r.Next(nodes.Count)];

            for(long i = 0; i < 1000000; i ++)
            {
                if (r.Next(6) == 6)
                {
                    currentNode = nodes[r.Next(nodes.Count)];
                }
                else
                {
                    currentNode = currentNode.RandomTravel();
                    currentNode.count++;
                }
            }
            
            foreach(Node n in nodes)
            {
                Console.WriteLine(n.label + ": " + ((double)n.count)/ 10000 + "%");
            }
            Console.ReadLine();

        }
    }
}
