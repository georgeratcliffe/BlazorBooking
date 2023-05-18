(function () {

    window.setdates = () => {

        $('table tr td:nth-child(3)').each(
            function () {
                var td = $(this)
                td.text(td.text().substring(0,9))
            }
        )
    }

})();