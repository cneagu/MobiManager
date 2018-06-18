function SPA() {

    function setActiveLink(fragmentId) {
        $(".page-content").each(function (i, divElement) {
            divElement = $(this).attr('id');
            if (divElement === fragmentId) {
                $(this).removeAttr("hidden");
            }
            else {
                $(this).attr("hidden", "true");
            }
        });
    }

    function navigate() {
        var fragmentIdcomplete = location.hash.substr(1);
        var fragmentId = fragmentIdcomplete.split("/");
        setActiveLink(fragmentId[0]);
    }

    if (!location.hash) {
        location.hash = "#home";
    }

    navigate();
    $(window).on('hashchange', function (e) {
        scroll(0, 0);
        navigate();
    });



    $(".singin-page").on("click", function () {
        window.location.hash = '#singin';

    });

    $(".main-search").on("click", function () {
        window.location.hash = '#search';
    });

    $(".back-home").on("click", function () {
        window.history.back();
    });


    $("#user-announcements").on("click", function () {
        $("#tabs").tabs({ active: 0 });
    });

    $("#user-messages").on("click", function () {
        $("#tabs").tabs({ active: 1 });
    });
}