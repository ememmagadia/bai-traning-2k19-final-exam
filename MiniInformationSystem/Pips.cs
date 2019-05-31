namespace MiniInformationSystem
{
        class Pips {
        private string strPersonID;
        private string strPersonName;

        public Pips(string strPersonID, string strPersonName)
        {
            this.strPersonID = strPersonID;
            this.strPersonName = strPersonName;
        }

        public int PersonID { get; set; }
        public string PersonName { get;  set; }

    }
    
         
    
}