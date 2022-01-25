﻿namespace CombatControlsRedux
{
    public class ModConfig
    {
        public bool MouseFix = true;
        public bool ControllerFix = false;
        public bool RegularToolsFix = false;

        public bool AutoSwing = false;
        public bool AutoSwingDagger = true;

        public bool SlickMoves = true;
        public bool SwordSpecialSlickMove = true;
        public bool ClubSpecialSlickMove = false;

        public float SlideVelocity = 4f;
        public float SpecialSlideVelocity = 2.8f;

        //undocumented options
        public bool Debug = false;//unused right now.
        public bool NearTileFacingFix = false;
    }
}

