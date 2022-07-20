namespace CodeFirst_Models.Contract.Base
{
    interface IBaseEntityPersonIdentity
    {
        /// <summary>
        /// For entities who needs an PersonID
        /// </summary>
        int PersonID { get; set; }
    }
}
