function Remove(url) {
    Swal.fire({
        title: "آیا از حذف اطمینان دارید؟",
        text: "شما قادر به بازگشت نخواهید بود!",
        icon: "warning",
        showCancelButton: false,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "بله. حذف کن!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function () {
                    location.reload();
                }
            })
        }
    });
}
