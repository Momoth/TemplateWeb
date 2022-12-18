namespace TemplateWeb.Repository.Abstraction.DAO.Security
{
    /// <summary>
    /// Rôle d'un utilisateur.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Identifiant technique auto généré.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Libellé du rôle.
        /// </summary>
        public string Libelle { get; set; } = null!;
    }
}