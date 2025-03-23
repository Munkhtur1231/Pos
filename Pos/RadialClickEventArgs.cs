namespace Pos;
public class RadialClickEventArgs:EventArgs
{
    public bool isPlus=false;
    public RadialClickEventArgs(bool isPlus)
    {
        this.isPlus = isPlus;
    }
}
