// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IndoorNavigation.iOS
{
    [Register ("MapViewController")]
    partial class MapViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView AutosuggestionsTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint BottomConstraint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ContactCardView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CurrentLocationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DirectionsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView FloorsTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem HomeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar LocationSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MainLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.UI.Controls.MapView MapView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SecondaryLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem SettingsButton { get; set; }

        [Action ("Home_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Home_TouchUpInside (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (AutosuggestionsTableView != null) {
                AutosuggestionsTableView.Dispose ();
                AutosuggestionsTableView = null;
            }

            if (BottomConstraint != null) {
                BottomConstraint.Dispose ();
                BottomConstraint = null;
            }

            if (ContactCardView != null) {
                ContactCardView.Dispose ();
                ContactCardView = null;
            }

            if (CurrentLocationButton != null) {
                CurrentLocationButton.Dispose ();
                CurrentLocationButton = null;
            }

            if (DirectionsButton != null) {
                DirectionsButton.Dispose ();
                DirectionsButton = null;
            }

            if (FloorsTableView != null) {
                FloorsTableView.Dispose ();
                FloorsTableView = null;
            }

            if (HomeButton != null) {
                HomeButton.Dispose ();
                HomeButton = null;
            }

            if (LocationSearchBar != null) {
                LocationSearchBar.Dispose ();
                LocationSearchBar = null;
            }

            if (MainLabel != null) {
                MainLabel.Dispose ();
                MainLabel = null;
            }

            if (MapView != null) {
                MapView.Dispose ();
                MapView = null;
            }

            if (SecondaryLabel != null) {
                SecondaryLabel.Dispose ();
                SecondaryLabel = null;
            }

            if (SettingsButton != null) {
                SettingsButton.Dispose ();
                SettingsButton = null;
            }
        }
    }
}