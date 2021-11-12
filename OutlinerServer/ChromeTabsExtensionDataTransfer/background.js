var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var url = "https://localhost:7098/CreateUpdateTempTabNodeDtos";
chrome.tabs.onCreated.addListener(tab => postData(url, tab));
//chrome.tabs.onUpdated.addListener(tab => postData(url, tab));
//chrome.tabs.onRemoved.addListener(tab => postData(url, tab));
function postData(url = '', data) {
    var _a, _b, _c, _d, _e, _f, _g, _h, _j, _k, _l, _m;
    return __awaiter(this, void 0, void 0, function* () {
        const tab = {
            "Id": (_b = (_a = data.id) === null || _a === void 0 ? void 0 : _a.toString()) !== null && _b !== void 0 ? _b : "",
            "openerTabId": (_d = (_c = data.openerTabId) === null || _c === void 0 ? void 0 : _c.toString()) !== null && _d !== void 0 ? _d : "",
            "Title": (_f = (_e = data.title) === null || _e === void 0 ? void 0 : _e.toString()) !== null && _f !== void 0 ? _f : "",
            "Url": (_h = (_g = data.url) === null || _g === void 0 ? void 0 : _g.toString()) !== null && _h !== void 0 ? _h : "",
            "FaviconUrl": (_k = (_j = data.favIconUrl) === null || _j === void 0 ? void 0 : _j.toString()) !== null && _k !== void 0 ? _k : "",
            "WindowId": (_m = (_l = data.windowId) === null || _l === void 0 ? void 0 : _l.toString()) !== null && _m !== void 0 ? _m : ""
        };
        console.log(tab);
        const response = yield fetch(url, {
            method: 'POST',
            mode: 'cors',
            cache: 'no-cache',
            credentials: 'same-origin',
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            redirect: 'follow',
            referrerPolicy: 'no-referrer',
            body: JSON.stringify(tab) // body data type must match "Content-Type" header
        });
        console.log(response); // parses JSON response into native JavaScript objects
        return response;
    });
}
//# sourceMappingURL=background.js.map