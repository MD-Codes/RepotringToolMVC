using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RepotringToolMVC.Models
{
    public class ParseAllData
    {
        public List<IMemberInfo> ProcessData(publicwhip regmem, ArrayOfIPartyAffiliation partyAff)
        {
            string AmountPat = @"(?<=£)\d{1,4}?,?\d{1,4}?,?\d{1,4}(.\d{2})?";
            string IdPat = @"\d{5}";
            string DonorPat = @"(?<=\bdonor:\s+)\p{L}.*";

            string donors = " ";
            double amount = 0;
            string PartyName = " ";

            List<IMemberInfo> displayList = new List<IMemberInfo>();

            if (regmem != null)
            {
                foreach (var member in regmem.regmem)
                {
                    var PersonName = member.membername;
                    MatchCollection matchesId = Regex.Matches(member.personid, IdPat);
                    var PersonID = Convert.ToInt32(matchesId[0].Value);

                    if (member.category != null)
                    {
                        //categories
                        foreach (var cat in member.category)
                        {

                            foreach (var rec in cat.record)
                            {
                                if (rec.Text != null && (cat.type == 2 || cat.type == 3 || cat.type == 4))
                                {
                                    foreach (var item in rec.Text)
                                    {
                                        MatchCollection donorCollection = Regex.Matches(item, DonorPat);
                                        if (donorCollection != null && donorCollection.Count > 0)
                                        {
                                            donors += Convert.ToString(donorCollection[0].Value) + ", ";
                                        }

                                    }

                                }
                                if (rec.strong != null)
                                {
                                    foreach (var emItem in rec.strong.em.Text)
                                    {
                                        MatchCollection donorCollection = Regex.Matches(emItem, DonorPat);
                                        if (donorCollection.Count > 0)
                                        {
                                            donors += Convert.ToString(donorCollection[0]) + ", ";
                                        }
                                    }
                                }
                                if (rec.br != null && (cat.type == 2 || cat.type == 3 || cat.type == 4))
                                {
                                    //rec->br
                                    foreach (var ItemBr in rec.br)
                                    {
                                        if (rec.br != null)
                                        {

                                            MatchCollection matches = Regex.Matches(ItemBr, AmountPat);
                                            foreach (var br in matches)
                                            {
                                                double nextAmount = Convert.ToDouble(br.ToString());
                                                amount = Math.Round((amount + nextAmount), 2);
                                            }
                                        }
                                    }
                                }
                                if (rec.strong != null && (cat.type == 2 || cat.type == 3 || cat.type == 4))
                                {
                                    //Strong->em->br
                                    foreach (var br in rec.strong.em.br)
                                    {
                                        MatchCollection matches = Regex.Matches(br, AmountPat);
                                        foreach (var itemBr in matches)
                                        {
                                            double nextAmount = Convert.ToDouble(itemBr.ToString());
                                            amount = Math.Round((amount + nextAmount), 2);
                                        }
                                    }
                                }
                            }
                        }
                    } // end of IF statement if category doesn't exist
                    foreach (var item in partyAff.IPartyAffiliation)
                    {
                        if (item.UserId == PersonID)
                        {
                            PartyName = item.PartyName;
                        }
                    }
                    displayList.Add(new IMemberInfo
                    {
                        UserId = PersonID,
                        Name = member.membername,
                        PartyName = PartyName,
                        Donors = donors,
                        TotalAmount = amount
                    });

                    amount = 0;
                    donors = "";
                } // end of first loop name, id 
            }

            return displayList;
        }
    }
}
