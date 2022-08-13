function DownloadCanvasImage() {
    let canvas = document.getElementsByTagName("canvas")
    let imageUrl = canvas[0].toDataURL("image/png");
    let link = document.createElement("a");
    link.href = imageUrl;
    link.download = true;
    link.click();
}