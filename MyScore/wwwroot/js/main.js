$(function () {
    $("#score").mask("9-9");
    setOptionTeamNoReset();
    $(".league-select").change(function () {
        setOptionTeam();
    });
});
function setOptionTeamNoReset() {
    $(".host-team-select option").each(function () {
        if ($(this).data("item") != ($(".league-select").val())) {
            $(this).hide();
        } else {
            $(this).show();
        };
    });
    $(".host-team-select option").each(function () {
        if ($(".league-select").val() == -1) {
            $('.host-team-select').prop('disabled', true);
            $('.guest-team-select').prop('disabled', true);
        } else {
            $('.host-team-select').prop('disabled', false);
            $('.guest-team-select').prop('disabled', false);
        }
        if ($(this).data("item") != ($(".league-select").val())) {
            $(this).hide();
        } else {
            $(this).show();
        };
    });
}
function setOptionTeam() {
    if ($(".league-select").val() == -1) {
        $('.host-team-select').prop('disabled', true);
        $('.guest-team-select').prop('disabled', true);
    } else {
        $('.host-team-select').prop('disabled', false);
        $('.guest-team-select').prop('disabled', false);
    }
    $('.host-team-select').val(-1);
    $('.guest-team-select').val(-1);

    $(".host-team-select option").each(function () {
        if ($(this).data("item") != ($(".league-select").val())) {
                $(this).hide();
            } else {
                $(this).show();
            };
    });
    $(".guest-team-select option").each(function () {
        if ($(this).data("item") != ($(".league-select").val())) {
            $(this).hide();
        } else {
            $(this).show();
        };
    });
}


function getLeagueId() {
    return $(".league-select").val();;
}
