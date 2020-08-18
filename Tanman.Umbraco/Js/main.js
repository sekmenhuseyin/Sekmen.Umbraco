// ReSharper disable IdentifierTypo

$(document).ready(function () {
    window.Dropzone.options.dropzoneForm = {
        addRemoveLinks: true,
        init: function () {
            this.on("success", function (data) {
                if (data === true) {
                    window.toastr["success"]("Dosya yüklendi", "Başarılı");
                } else {
                    window.toastr["error"]("Dosya yüklenemedi", "Hata");
                }
            });
            this.on("error", function (data) {
                console.log(data);
                window.toastr["error"]("Dosya yüklenemedi", "Hata");
            });
            this.on("complete", function (file) { this.removeFile(file); });
            this.on("canceled", function (file) { this.removeFile(file); });
        },
        uploadprogress: function (file, progress, bytesSent) {
            if (file.previewElement) {
                var progressElement = file.previewElement.querySelector("[data-dz-uploadprogress]");
                progressElement.style.width = progress + "%";
                progressElement.querySelector(".progress-text").textContent = progress + "%";
            }
        }
    };

});