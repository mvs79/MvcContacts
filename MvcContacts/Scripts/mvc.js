$(function () {

    var ajaxFormSubmit = function () {
        $form = $(this)
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        }
        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-mvc-target"));
            $target.replaceWith(data);
        });

        return false

        //var createAutoComplete = function () {
        //    var $input = $(this);
        //    var options = {
        //        source: $input.attr("data-mvc-autocomplete")
        //    };
        //    $input.autocomplete(options);

        //};
    };
    $("form[data-mvc-ajax='true']").submit(ajaxFormSubmit);
    //$("input[data-mvc-autocomplete]").each(createAutoComplete);
});
    