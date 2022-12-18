namespace TemplateWeb.Repository.Abstraction.DAO.Security
{
    /// <summary>
    /// D�finission d'un utilisateur.
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Identifiant technique auto g�n�r�.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Email de l'utilisateur. Login unique de l'utilisateur.
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Nom de l'utilisateur.
        /// </summary>
        public string Nom { get; set; } = null!;

        /// <summary>
        /// Pr�nom de l'utilisateur.
        /// </summary>
        public string Prenom { get; set; } = null!;
    }
}