(function () {

    window.setdates = () => {

        $('table tr td:nth-child(3)').each(
            function () {
                var td = $(this)

                var dateAr = td.text().substring(0, 9).split('/')

                var newDate = dateAr[1].slice(-2) + '/' + dateAr[0].slice(-2) + '/' + dateAr[2];
                td.text(newDate)
            }
        )
    }

})();