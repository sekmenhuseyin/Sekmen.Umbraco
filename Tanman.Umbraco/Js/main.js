// ReSharper disable IdentifierTypo
window.Dropzone.options.dropzoneForm = {
    addRemoveLinks: true,
    init: function () {
        this.on("success", function (data) {
            if (data === true) {
                window.toastr["success"]("Dosya yüklendi", "Başarılı");
            } else {
                window.toastr["error"]("Dosya yüklenemedi", "Hata");
                $(".dz-error").remove();
            }
        });
        this.on("error", function (data) {
            window.toastr["error"]("Dosya yüklenemedi", "Hata");
            $(".dz-error").remove();
        });
        this.on("complete", function (file) { this.removeFile(file); });
        this.on("canceled", function (file) { this.removeFile(file); });
    }
};