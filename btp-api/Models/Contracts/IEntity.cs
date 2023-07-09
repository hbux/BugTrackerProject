namespace btp_api.Models.Contracts
{
    /// <summary>
    /// Used for determining which models are used with EFCore DbContext
    /// </summary>
    public interface IEntity
    {
        public string Id { get; set; }
    }
}
