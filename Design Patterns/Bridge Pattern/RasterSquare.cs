namespace BridgePattern
{
    public class RasterSquare : IRenderer
    {
        public string WhatToRenderAs
        {
            get { return "pixels"; }
        }
    }
}

