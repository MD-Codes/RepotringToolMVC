using RepotringToolMVC.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepotringToolMVC.Models
{
    public class Model : IModel
    {
        public List<IMemberInfo> ReturnData()
        {
            ParseAllData parse = new ParseAllData();

            //retrieve data from LoadFiles
            publicwhip regmem = new LoadFiles<publicwhip>().LoadFile(Resources.AllData);
            ArrayOfIPartyAffiliation partyAff = new LoadFiles<ArrayOfIPartyAffiliation>().LoadFile(Resources.myFileName);

            // Process data using the DataProcessor
            List<IMemberInfo> displayList = parse.ProcessData(regmem, partyAff);

            return displayList;
        }
       
    }
}
