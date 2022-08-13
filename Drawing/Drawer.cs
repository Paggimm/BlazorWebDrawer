using System.Drawing;
using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.AspNetCore.Components.Web;

namespace DefaultNamespace;

/// Class to actually draw on a given canvas
/// drawing-properties are configured in DrawerConfig
public class Drawer
{
    public bool DrawingEnabled { get; set; }
    private readonly DrawerConfig _drawerConfig = new();
    private readonly Canvas2DContext _canvasContext;

    public Drawer( Canvas2DContext canvasContext)
    {
        _canvasContext = canvasContext;
    }
    
    /// makes the actual draw on the canvas
    public async void Draw(MouseEventArgs mouseEvent)
    {
        if (DrawingEnabled)
        {
            await _canvasContext.SetFillStyleAsync(_drawerConfig.Color);
            await _canvasContext.FillRectAsync(mouseEvent.OffsetX - (_drawerConfig.BrushSize/2d), mouseEvent.OffsetY - (_drawerConfig.BrushSize/2d), _drawerConfig.BrushSize, _drawerConfig.BrushSize);
        }
    }

    public void SetBrushSize(int size)
    {
        _drawerConfig.BrushSize = size;
    }
}