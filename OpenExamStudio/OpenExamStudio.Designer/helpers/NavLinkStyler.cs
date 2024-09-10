using System.Linq;
using DevExpress.XtraNavBar;
using DevExpress.Mvvm.Native;
using System.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace OpenExamStudio.Designer
{
    public class NavLinkStyler
    {
        private readonly NavBarControl _navBarControl;
        private Color _navBaseColour;
        private NavBarItem _lastSelectedItem;

        public NavLinkStyler(NavBarControl navBarControl)
        {
            _navBarControl = navBarControl;
        }

        public void StyleNavLink(NavBarItemLink link)
        {
            _navBarControl.BeginUpdate();

            if (_navBaseColour == null)
                _navBaseColour = _navBarControl.Items.First().Appearance.ForeColor;

            // Reset all items to the base color
            _navBarControl.Items.ForEach(item => item.Appearance.ForeColor = _navBaseColour);

            // Reset the font and color of the last selected item
            if (_lastSelectedItem != null)
            {
                _lastSelectedItem.Appearance.Font = new Font(_navBarControl.Font, FontStyle.Regular);
                _lastSelectedItem.Appearance.ForeColor = Color.Empty; // Reset to default color
            }

            // Set the font weight and color of the current selected item
            if (link != null)
            {
                _lastSelectedItem = link.Item;
                _lastSelectedItem.Appearance.Font = new Font(_navBarControl.Font, FontStyle.Bold);
                _lastSelectedItem.Appearance.ForeColor = GetSkinAccentColor();
            }

            _navBarControl.EndUpdate();
        }

        private Color GetSkinAccentColor()
        {
            // Retrieve the current active skin's color palette
            var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            return skin.Colors["Primary"]; // "Primary" is often used for the accent color in DevExpress skins
        }
    }

}