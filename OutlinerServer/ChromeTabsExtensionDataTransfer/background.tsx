
var url = "https://localhost:7098/CreateUpdateTempTabNodeDtos";
chrome.tabs.onCreated.addListener(tab => postData(url, tab));
//chrome.tabs.onUpdated.addListener(tab => postData(url, tab));
//chrome.tabs.onRemoved.addListener(tab => postData(url, tab));


async function postData(url = '', data: chrome.tabs.Tab) {
    const tab = {
        "Id": data.id?.toString() ?? "",
        "openerTabId": data.openerTabId?.toString() ?? "",
        "Title": data.title?.toString() ?? "",
        "Url": data.url?.toString() ?? "",
        "FaviconUrl": data.favIconUrl?.toString() ?? "",
        "WindowId": data.windowId?.toString() ?? ""
    }
    console.log(tab);
    const response = await fetch(url, {
        method: 'POST', // *GET, POST, PUT, DELETE, etc.
        mode: 'cors', // no-cors, *cors, same-origin
        cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
        credentials: 'same-origin', // include, *same-origin, omit
        headers: {
            'Content-Type': 'application/json'
            // 'Content-Type': 'application/x-www-form-urlencoded',
        },
        redirect: 'follow', // manual, *follow, error
        referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
        body: JSON.stringify(tab) // body data type must match "Content-Type" header
    });
    console.log(response); // parses JSON response into native JavaScript objects
    return response;
}

