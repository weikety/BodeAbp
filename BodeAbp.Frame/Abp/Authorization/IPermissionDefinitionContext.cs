using Abp.Localization;

namespace Abp.Authorization
{
    /// <summary>
    /// This context is used on <see cref="AuthorizationProvider.SetPermissions"/> method.
    /// </summary>
    public interface IPermissionDefinitionContext
    {
        /// <summary>
        /// Creates a new permission under this group.
        /// </summary>
        /// <param name="name">Unique name of the permission</param>
        /// <param name="displayName">Display name of the permission</param>
        /// <param name="isGrantedByDefault">Is this permission granted by default. Default value: false.</param>
        /// <param name="description">A brief description for this permission</param>
        /// <returns>New created permission</returns>
        Permission CreatePermission(
            string name, 
            ILocalizableString displayName = null, 
            bool isGrantedByDefault = false, 
            ILocalizableString description = null
            );

        /// <summary>
        /// Gets a permission with given name or null if can not find.
        /// </summary>
        /// <param name="name">Unique name of the permission</param>
        /// <returns>Permission object or null</returns>
        Permission GetPermissionOrNull(string name);
    }
}