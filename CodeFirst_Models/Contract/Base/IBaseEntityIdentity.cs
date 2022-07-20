namespace CodeFirst_Models.Contract.Base
{
    interface IBaseEntityIdentity
    {
        /// <summary>
        /// For entities who needs an ID
        /// </summary>
        int ID { get; set; }
    }
}
