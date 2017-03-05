﻿namespace Konsole
{
    // (K) Konsole shortcut options
    public enum K
    {
        // coming soon
        // -----------
        // really simple shortcut settings for windows
        //TL, // Top left 50% wide and high
        //TR, // Top Right 50% wide and high
        //BL, // Bottom left 50% wide and high
        //BR, // Bottom Right 50% wide and high
        //R, // Split screen 50% left and right (right)
        //L, // Split screen 50% left and right (Left)
        //B, // Split screen 50% top and bottom (top)


        // currently under development
        // ---------------------------
        Transparent, // window background color is transparent until you start writing then will print using the configured fore and background color i.e. initial window will not clear the background
        FullScreen, // window background color is transparent until you start writing then will print using the configured fore and background color i.e. initial window will not clear the background
        Clipping, // printing off the screen is clipped, no scrolling.
        Scrolling, // printing off the bottom of the window causes the window to scroll. (cannot be used in conjunction with Clipping) Scrolling is the default window behavior.
    }
}
