function direct(url, submitObj) {

    var paramterStr = "";

    if (submitObj) {

        $.each(submitObj, function (key, value) {
            paramterStr += "&" + key + "=" + value
        });
    }
    window.location.href = (url + "?" + (paramterStr.substring(1)));

}

//files:檔案;judgeType:判斷類行;width:限制的寬;height:限制的高;obj:要限制的物件
function checkImageSize(files, judgeType, width, height,obj) {
    var reader = new FileReader();
    
    reader.onload = function (e) {
        var ischeck = true;
        var showMessage = "";
        var img = new Image();

        img.src = e.target.result;
        img.onload = function () {
            switch (judgeType) {
                case 0:
                    if (this.width != width || this.height != height) {
                        ischeck = false;
                        showMessage = "請選擇寬:" + width + "px及高:" + height + "px的圖片";
                    };
                    break;
                case 1:
                    if (this.width != width) {
                        ischeck = false;
                        showMessage = "請選擇寬:" + width + "px的圖片";
                    };
                    break;
                case 2:
                    if (this.height != height) {
                        ischeck = false;
                        showMessage = "請選擇高:" + height + "px的圖片";
                    };
                    break;
            };

            if (!ischeck) {
                window.PTC.alertPop.normal({
                    title: showMessage,
                    message: "",
                    type: window.PTC.Enum.AlertPopType.warning
                })
                $(obj).fileinput('clear');
            };
        };
    };
    reader.readAsDataURL(files);
};