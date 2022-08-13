// tries to save the content of the first found canvas as png
function DownloadCanvasImage() {
    let canvas = document.getElementsByTagName("canvas")
    if(canvas === undefined) {
        throw Error("No Canvas found on Site")
    }
    else {
        let imageUrl = canvas[0].toDataURL("image/png");
        let link = document.createElement("a");
        link.href = imageUrl;
        link.download = true;
        link.click();
    }
}