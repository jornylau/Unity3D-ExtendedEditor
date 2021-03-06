﻿using UnityEditor;
using UnityEngine;

namespace TNRD.Editor.Utilities {

    /// <summary>
    /// A helper to make it easier to create Unity's GenericMenu
    /// </summary>
    public class GenericMenuBuilder {

        /// <summary>
        /// Creates a new instance of GenericMenuBuilder
        /// </summary>
        /// <returns></returns>
        public static GenericMenuBuilder CreateMenu() {
            return new GenericMenuBuilder();
        }

        /// <summary>
        /// The menu that is being created
        /// </summary>
        public GenericMenu Menu;

        public GenericMenuBuilder() {
            Menu = new GenericMenu();
        }

        /// <summary>
        /// Adds a disabled item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        public GenericMenuBuilder AddDisabledItem( string content ) {
            Menu.AddDisabledItem( new GUIContent( content ) );
            return this;
        }

        /// <summary>
        /// Adds a disabled item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        public GenericMenuBuilder AddDisabledItem( GUIContent content ) {
            Menu.AddDisabledItem( content );
            return this;
        }

        /// <summary>
        /// Adds an item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        /// <param name="showTick">Should the item show a check in front of it</param>
        /// <param name="enabled">Should the item be enabled or disabled</param>
        public GenericMenuBuilder AddItem( string content, bool showTick, bool enabled = true ) {
            if ( enabled )
                Menu.AddItem( new GUIContent( content ), showTick, null );
            else
                Menu.AddDisabledItem( new GUIContent( content ) );

            return this;
        }

        /// <summary>
        /// Adds an item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        /// <param name="showTick">Should the item show a check in front of it</param>
        /// <param name="enabled">Should the item be enabled or disabled</param>
        public GenericMenuBuilder AddItem( GUIContent content, bool showTick, bool enabled = true ) {
            if ( enabled )
                Menu.AddItem( content, showTick, null );
            else
                Menu.AddDisabledItem( content );

            return this;
        }

        /// <summary>
        /// Adds an item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        /// <param name="showTick">Should the item show a check in front of it</param>
        /// <param name="func">The function to call when this item is clicked</param>
        /// <param name="enabled">Should the item be enabled or disabled</param>
        public GenericMenuBuilder AddItem( string content, bool showTick, GenericMenu.MenuFunction func, bool enabled = true ) {
            if ( enabled )
                Menu.AddItem( new GUIContent( content ), showTick, func );
            else
                Menu.AddDisabledItem( new GUIContent( content ) );

            return this;
        }

        /// <summary>
        /// Adds an item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        /// <param name="showTick">Should the item show a check in front of it</param>
        /// <param name="func">The function to call when this item is clicked</param>
        /// <param name="enabled">Should the item be enabled or disabled</param>
        public GenericMenuBuilder AddItem( GUIContent content, bool showTick, GenericMenu.MenuFunction func, bool enabled = true ) {
            if ( enabled )
                Menu.AddItem( content, showTick, func );
            else
                Menu.AddDisabledItem( content );

            return this;
        }

        /// <summary>
        /// Adds an item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        /// <param name="showTick">Should the item show a check in front of it</param>
        /// <param name="func">The function to call when this item is clicked</param>
        /// <param name="data">The data to pass to the function</param>
        /// <param name="enabled">Should the item be enabled or disabled</param>
        public GenericMenuBuilder AddItem( string content, bool showTick, GenericMenu.MenuFunction2 func, object data, bool enabled = true ) {
            if ( enabled )
                Menu.AddItem( new GUIContent( content ), showTick, func, data );
            else
                Menu.AddDisabledItem( new GUIContent( content ) );

            return this;
        }

        /// <summary>
        /// Adds an item to the menu
        /// </summary>
        /// <param name="content">The content to display</param>
        /// <param name="showTick">Should the item show a check in front of it</param>
        /// <param name="func">The function to call when this item is clicked</param>
        /// <param name="data">The data to pass to the function</param>
        /// <param name="enabled">Should the item be enabled or disabled</param>
        public GenericMenuBuilder AddItem( GUIContent content, bool showTick, GenericMenu.MenuFunction2 func, object data, bool enabled = true ) {
            if ( enabled )
                Menu.AddItem( content, showTick, func, data );
            else
                Menu.AddDisabledItem( content );

            return this;
        }

        /// <summary>
        /// Adds a separator to the top level of the menu
        /// </summary>
        public GenericMenuBuilder AddSeparator() {
            Menu.AddSeparator( "" );
            return this;
        }

        /// <summary>
        /// Adds a separator to the specified path/level of the menu
        /// </summary>
        /// <param name="path">The path/level for the separator</param>
        /// <returns></returns>
        public GenericMenuBuilder AddSeparator( string path ) {
            Menu.AddSeparator( path );
            return this;
        }

        /// <summary>
        /// Shows the menu at the given screen rect
        /// </summary>
        /// <param name="position">The rect for the menu</param>
        public void DropDown( Rect position ) {
            Menu.DropDown( position );
        }

        /// <summary>
        /// Shows the menu under the mouse when right-clicked
        /// </summary>
        public void ShowAsContext() {
            Menu.ShowAsContext();
        }
    }
}