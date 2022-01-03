﻿// Decompiled with JetBrains decompiler
// Type: BrightIdeasSoftware.IRenderer
// Assembly: SWPS4MAX, Version=1.0.7646.26709, Culture=neutral, PublicKeyToken=null
// MVID: 185BF9ED-B762-4AE8-B9E6-BAC5BF775B8B
// Assembly location: C:\Program Files (x86)\DataPower\Save Wizard for PS4 MAX\SWPS4MAX.exe

using System.Drawing;
using System.Windows.Forms;

namespace BrightIdeasSoftware
{
  public interface IRenderer
  {
    bool RenderItem(
      DrawListViewItemEventArgs e,
      Graphics g,
      Rectangle itemBounds,
      object rowObject);

    bool RenderSubItem(
      DrawListViewSubItemEventArgs e,
      Graphics g,
      Rectangle cellBounds,
      object rowObject);

    void HitTest(OlvListViewHitTestInfo hti, int x, int y);

    Rectangle GetEditRectangle(
      Graphics g,
      Rectangle cellBounds,
      OLVListItem item,
      int subItemIndex,
      Size preferredSize);
  }
}
