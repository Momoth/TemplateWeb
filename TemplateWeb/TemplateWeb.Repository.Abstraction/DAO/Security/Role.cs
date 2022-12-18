namespace TemplateWeb.Repository.Abstraction.DAO.Security
{
    /// <summary>
    /// R�le d'un utilisateur.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Identifiant technique auto g�n�r�.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Libell� du r�le.
        /// </summary>
        public string Libelle { get; set; } = null!;
    }
}