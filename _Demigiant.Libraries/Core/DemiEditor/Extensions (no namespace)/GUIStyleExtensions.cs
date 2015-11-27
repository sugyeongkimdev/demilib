﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2015/04/29 19:07

using System;
using DG.DemiLib;
using UnityEngine;

namespace DG.DemiEditor
{
    /// <summary>
    /// GUI extension methods
    /// </summary>
    public static class GUIStyleExtensions
    {
        #region Add Methods

        /// <summary>
        /// Clones the style and adds the given formats to it
        /// </summary>
        public static GUIStyle Clone(this GUIStyle style, params object[] formats)
        {
            return new GUIStyle(style).Add(formats);
        }
        /// <summary>
        /// Adds the given formats to the style
        /// </summary>
        public static GUIStyle Add(this GUIStyle style, params object[] formats)
        {
            foreach (object f in formats) {
                Type t = f.GetType();
                if (t == typeof(Format)) {
                    switch ((Format)f) {
                    case Format.RichText:
                        style.richText = true;
                        break;
                    case Format.WordWrap:
                        style.wordWrap = true;
                        break;
                    }
                } else if (t == typeof(FontStyle)) {
                    style.fontStyle = (FontStyle)f;
                } else if (t == typeof(TextAnchor)) {
                    style.alignment = (TextAnchor)f;
                } else if (t == typeof(FontStyle)) {
                    style.fontStyle = (FontStyle)f;
                } else if (t == typeof(int)) {
                    style.fontSize = (int)f;
                } else if (t == typeof(Color) || t == typeof(DeSkinColor)) {
                    style.normal.textColor = style.active.textColor = t == typeof(Color) ? (Color)f : (Color)(DeSkinColor)f;
                }
            }
            return style;
        }

        #endregion

        #region Style Methods

        /// <summary>
        /// Sets the border of the style
        /// </summary>
        public static GUIStyle Border(this GUIStyle style, RectOffset border)
        {
            style.border = border;
            return style;
        }
        /// <summary>
        /// Sets the border of the style
        /// </summary>
        public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom)
        {
            style.border = new RectOffset(left, right, top, bottom);
            return style;
        }

        /// <summary>
        /// Sets the background of the style
        /// </summary>
        public static GUIStyle Background(this GUIStyle style, Texture2D background)
        {
            style.normal.background = style.active.background = background;
            return style;
        }

        /// <summary>
        /// Sets the contentOffset of the style
        /// </summary>
        public static GUIStyle ContentOffset(this GUIStyle style, Vector2 offset)
        {
            style.contentOffset = offset;
            return style;
        }
        /// <summary>
        /// Sets the X contentOffset of the style
        /// </summary>
        public static GUIStyle ContentOffsetX(this GUIStyle style, float offsetX)
        {
            Vector2 offset = style.contentOffset;
            offset.x = offsetX;
            style.contentOffset = offset;
            return style;
        }
        /// <summary>
        /// Sets the Y contentOffset of the style
        /// </summary>
        public static GUIStyle ContentOffsetY(this GUIStyle style, float offsetY)
        {
            Vector2 offset = style.contentOffset;
            offset.y = offsetY;
            style.contentOffset = offset;
            return style;
        }

        /// <summary>
        /// Sets the margin of the style
        /// </summary>
        public static GUIStyle Margin(this GUIStyle style, RectOffset margin)
        {
            style.margin = margin;
            return style;
        }
        /// <summary>
        /// Sets the margin of the style
        /// </summary>
        public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom)
        {
            style.margin = new RectOffset(left, right, top, bottom);
            return style;
        }
        /// <summary>
        /// Sets the left margin of the style
        /// </summary>
        public static GUIStyle MarginLeft(this GUIStyle style, int left)
        {
            style.margin.left = left;
            return style;
        }
        /// <summary>
        /// Sets the right margin of the style
        /// </summary>
        public static GUIStyle MarginRight(this GUIStyle style, int right)
        {
            style.margin.right = right;
            return style;
        }
        /// <summary>
        /// Sets the top margin of the style
        /// </summary>
        public static GUIStyle MarginTop(this GUIStyle style, int top)
        {
            style.margin.top = top;
            return style;
        }
        /// <summary>
        /// Sets the bottom margin of the style
        /// </summary>
        public static GUIStyle MarginBottom(this GUIStyle style, int bottom)
        {
            style.margin.bottom = bottom;
            return style;
        }

        /// <summary>
        /// Sets the padding of the style
        /// </summary>
        public static GUIStyle Padding(this GUIStyle style, RectOffset padding)
        {
            style.padding = padding;
            return style;
        }
        /// <summary>
        /// Sets the padding of the style
        /// </summary>
        public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom)
        {
            style.padding = new RectOffset(left, right, top, bottom);
            return style;
        }
        /// <summary>
        /// Sets the left padding of the style
        /// </summary>
        public static GUIStyle PaddingLeft(this GUIStyle style, int left)
        {
            style.padding.left = left;
            return style;
        }
        /// <summary>
        /// Sets the right padding of the style
        /// </summary>
        public static GUIStyle PaddingRight(this GUIStyle style, int right)
        {
            style.padding.right = right;
            return style;
        }
        /// <summary>
        /// Sets the top padding of the style
        /// </summary>
        public static GUIStyle PaddingTop(this GUIStyle style, int top)
        {
            style.padding.top = top;
            return style;
        }
        /// <summary>
        /// Sets the bottom padding of the style
        /// </summary>
        public static GUIStyle PaddingBottom(this GUIStyle style, int bottom)
        {
            style.padding.bottom = bottom;
            return style;
        }

        /// <summary>
        /// Sets the Y fixedWidth of the style
        /// </summary>
        public static GUIStyle Width(this GUIStyle style, float width)
        {
            style.fixedWidth = width;
            return style;
        }
        /// <summary>
        /// Sets the fixedHeight of the style
        /// </summary>
        public static GUIStyle Height(this GUIStyle style, int height)
        {
            style.fixedHeight = height;
            return style;
        }

        /// <summary>
        /// Sets the stretchHeight property of the style
        /// </summary>
        public static GUIStyle StretchHeight(this GUIStyle style, bool doStretch = true)
        {
            style.stretchHeight = doStretch;
            return style;
        }
        /// <summary>
        /// Sets the stretchWidth property of the style
        /// </summary>
        public static GUIStyle StretchWidth(this GUIStyle style, bool doStretch = true)
        {
            style.stretchWidth = doStretch;
            return style;
        }

        #endregion
    }
}