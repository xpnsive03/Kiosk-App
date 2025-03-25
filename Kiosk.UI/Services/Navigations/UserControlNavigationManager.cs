using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Core.Services.Navigations
{
    internal class UserControlNavigationManager
    {
        /// <summary>
        /// The panel container where the UserControls will be displayed.
        /// </summary>
        private readonly Panel _container;

        /// <summary>
        /// A dictionary to store instantiated strategies to avoid unnecessary re-creation.
        /// </summary>
        private readonly Dictionary<Type, IUserControlNavigation> _navigations = new();

        /// <summary>
        /// Keeps track of the currently active UserControl to prevent redundant loading.
        /// </summary>
        private UserControl _currentControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControlStrategyManager"/> class.
        /// </summary>
        /// <param name="container">The panel where UserControls will be loaded.</param>
        public UserControlNavigationManager(Panel container)
        {
            _container = container;
        }

        /// <summary>
        /// Sets the strategy for displaying a UserControl, ensuring only one instance of each control type is used.
        /// </summary>
        /// <typeparam name="T">The type of the strategy to use, which must implement <see cref="IUserControlNavigation"/>.</typeparam>
        public void SetNavigation<T>() where T : IUserControlNavigation, new()
        {
            // If the currently displayed UserControl is already of the requested type, do nothing.
            if (_currentControl != null && _currentControl.GetType() == typeof(T))
                return;

            // Check if the strategy for this control type already exists; if not, create and store it.
            if (!_navigations.ContainsKey(typeof(T)))
            {
                _navigations[typeof(T)] = new T();
            }

            // Clear the container before adding the new UserControl.
            _container.Controls.Clear();

            // Retrieve the new UserControl from the selected strategy.
            _currentControl = _navigations[typeof(T)].GetUserControl();
            _currentControl.Dock = DockStyle.Fill; // Ensure it fills the container.

            // Add the new UserControl to the container.
            _container.Controls.Add(_currentControl);
        }
    }
}
