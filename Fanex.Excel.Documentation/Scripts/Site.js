
var site =
    {
        cachedDOM:
            {
                parentMenu: null,
                toggleMenu: null,
                leftPanel: null,
                rightPanel: null,
                sampleLinks: null
            },
        registerEvents: function () {
            site.cachedDOM.parentMenu
                .off('click.grid')
                .on('click.grid', function () {
                    var $this = $(this);
                    if ($this.data('hide-child')) {
                        $this.next().show(500);
                        $this.data('hide-child', false)
                        .find('.glyphicon').removeClass('glyphicon-plus').addClass('glyphicon-minus');
                    }
                    else {
                        $this.next().hide(500);
                        $this.data('hide-child', true)
                        .find('.glyphicon').removeClass('glyphicon-minus').addClass('glyphicon-plus');
                    }
                });

            site.cachedDOM.toggleMenu
                .off('click.grid')
                .on('click.grid', function () {
                    var $this = $(this);
                    var isHide = $this.data('is-hide');
                    if (isHide) {
                        site.cachedDOM.leftPanel.show(500);
                        site.cachedDOM.rightPanel.addClass('show-left');
                    } else {
                        site.cachedDOM.leftPanel.hide(500);
                        site.cachedDOM.rightPanel.removeClass('show-left');
                    }

                    $this.data('is-hide', !isHide);
                    $(window).trigger('resize');
                });

            site.cachedDOM.sampleLinks
            .off('click.sampleLinks')
            .on('click.sampleLinks', function () {
                var $this = $(this);
                if (window.history.pushState) {
                    window.history.pushState(null, "CurrentSample", $this.attr('href').replace('SamplePage', 'Index'));
                }
            });
        },
        initialize: function () {
            site.cachedDOM.parentMenu = $('.list-menu-header');
            site.cachedDOM.toggleMenu = $('#toggleMenu');
            site.cachedDOM.leftPanel = $('#mainContent .left-panel');
            site.cachedDOM.rightPanel = $('#mainContent .right-panel');
            site.cachedDOM.sampleLinks = site.cachedDOM.leftPanel.find('a[target=sampleFrameContent]');

            site.registerEvents();
        }
    };

$(function () {
    site.initialize();
})