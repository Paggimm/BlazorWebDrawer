// tries to save the content of the first found canvas as png
export function DownloadCanvasImage() {
    const canvas = document.getElementsByTagName('canvas')[0];
    if(canvas === undefined) {
        throw Error('No Canvas found on Site');
    }
    else {
        const imageUrl = canvas.toDataURL('image/png');
        const link = document.createElement('a');
        link.href = imageUrl;
        link.download = 'canvasArt';
        link.click();
    }
}

DownloadCanvasImage();