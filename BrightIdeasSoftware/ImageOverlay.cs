﻿// Decompiled with JetBrains decompiler
// Type: BrightIdeasSoftware.ImageOverlay
// Assembly: SWPS4MAX, Version=1.0.7646.26709, Culture=neutral, PublicKeyToken=null
// MVID: 185BF9ED-B762-4AE8-B9E6-BAC5BF775B8B
// Assembly location: C:\Program Files (x86)\DataPower\Save Wizard for PS4 MAX\SWPS4MAX.exe

using System;
using System.ComponentModel;
using System.Drawing;

namespace BrightIdeasSoftware
{
  [TypeConverter("BrightIdeasSoftware.Design.OverlayConverter")]
  public class ImageOverlay : ImageAdornment, ITransparentOverlay, IOverlay
  {
    private int insetX = 20;
    private int insetY = 20;

    public ImageOverlay() => this.Alignment = ContentAlignment.BottomRight;

    [Category("ObjectListView")]
    [Description("The horizontal inset by which the position of the overlay will be adjusted")]
    [DefaultValue(20)]
    [NotifyParentProperty(true)]
    public int InsetX
    {
      get => this.insetX;
      set => this.insetX = Math.Max(0, value);
    }

    [Category("ObjectListView")]
    [Description("Gets or sets the vertical inset by which the position of the overlay will be adjusted")]
    [DefaultValue(20)]
    [NotifyParentProperty(true)]
    public int InsetY
    {
      get => this.insetY;
      set => this.insetY = Math.Max(0, value);
    }

    public virtual void Draw(ObjectListView olv, Graphics g, Rectangle r)
    {
      Rectangle r1 = r;
      r1.Inflate(-this.InsetX, -this.InsetY);
      this.DrawImage(g, r1, this.Image, (int) byte.MaxValue);
    }
  }
}
