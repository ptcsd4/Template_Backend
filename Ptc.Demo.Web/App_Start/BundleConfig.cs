using System.Web;
using System.Web.Optimization;

namespace Ptc.Demo.Web
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/css").Include(
                                        "~/Content/bootstrap.css",
                                        "~/Content/font-awesome.css"));


            bundles.Add(new StyleBundle("~/Content/css/Ace").Include(
                                        "~/Content/Ace/ace-fonts.css",
                                        "~/Content/Ace/ace.css"));

            bundles.Add(new StyleBundle("~/Content/css/JQuery-DataTable").Include(
                                        "~/Content/JQuery-DataTable/select.dataTables.min.css",
                                        "~/Content/JQuery-DataTable/dataTables.bootstrap.min.css",
                                        "~/Content/JQuery-DataTable/responsive.bootstrap.min.css",
                                        "~/Content/JQuery-DataTable/autoFill.dataTables.min.css",
                                        "~/Content/JQuery-DataTable/buttons.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/Krajee-FileInput").Include(
                                        "~/Content/Krajee-FileInput/fileinput.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/Bs-Select2").Include(
                                        "~/Content/Bs-Select2/select2.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/Bs-Duallistbox").Include(
                                        "~/Content/Bs-Duallistbox/bootstrap-duallistbox.css"));

            bundles.Add(new StyleBundle("~/Content/css/Sweetalert2").Include(
                                        "~/Content/Sweetalert2/sweetalert2.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/Bs-DateTime").Include(
                                        "~/Content/Bs-DateTime/daterangepicker.css"));

            bundles.Add(new StyleBundle("~/Content/css/Flora-Editor").Include(
                                        "~/Content/Flora-Editor/froala_editor.pkgd.min.css",
                                        "~/Content/Flora-Editor/froala_style.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/Bs-Treeview").Include(
                                        "~/Content/Bs-Treeview/bootstrap-treeview.css"));

            bundles.Add(new ScriptBundle("~/Scripts/js/JQuery").Include(
                                         "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/JQueryval").Include(
                                         "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/Scripts/js/JQueryui").Include(
                                         "~/Scripts/jquery-ui.min.js"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/Scripts/js/Modernizr").Include(
                                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/js/Bootstrap").Include(
                                         "~/Scripts/bootstrap.js",
                                         "~/Scripts/respond.js"));



            bundles.Add(new ScriptBundle("~/Scripts/js/JQuery-Validator").Include(
                                         "~/Scripts/JQuery-Validator/jquery.validate.min.js",
                                         "~/Scripts/JQuery-Validator/additional-methods.min.js",
                                         "~/Scripts/JQuery-Validator/messages_zh_TW.js",
                                         "~/Scripts/JQuery-Validator/PTCValidation.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/Krajee-FileInput").Include(
                                         "~/Scripts/Krajee-FileInput/fileinput.min.js",
                                         "~/Scripts/Krajee-FileInput/fileinput_zhTW.js",
                                         "~/Scripts/Krajee-FileInput/PTCFileInput.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/Bs-DateTime").Include(
                                         "~/Scripts/Bs-DateTime/moment.min.js",
                                         "~/Scripts/Bs-DateTime/bootstrap-datepicker.min.js",
                                         "~/Scripts/Bs-DateTime/bootstrap-datetimepicker.min.js",
                                         "~/Scripts/Bs-DateTime/bootstrap-timepicker.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/JQuery-DataTable").Include(
                                         "~/Scripts/JQuery-DataTable/jquery.dataTables.min.js",
                                         "~/Scripts/JQuery-DataTable/dataTables.bootstrap.min.js",
                                         "~/Scripts/JQuery-DataTable/dataTables.fixedHeader.min.js",
                                         "~/Scripts/JQuery-DataTable/dataTables.responsive.min.js",
                                         "~/Scripts/JQuery-DataTable/responsive.bootstrap.min.js",
                                         "~/Scripts/JQuery-DataTable/dataTables.buttons.min.js",
                                         "~/Scripts/JQuery-DataTable/dataTables.select.min.js",
                                         "~/Scripts/JQuery-DataTable/dataTables-zhTW.js",
                                         "~/Scripts/JQuery-DataTable/colResizable-1.5.min.js",
                                         "~/Scripts/JQuery-DataTable/PTCFloatTableFooter.js",
                                         "~/Scripts/JQuery-DataTable/PTCDatatables.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/Ptc-Tab").Include(
                                         "~/Scripts/Ptc-Tab/PTCTabview.js"));


            bundles.Add(new ScriptBundle("~/Scripts/js/Bs-Select2").Include(
                                         "~/Scripts/Bs-Select2/select2.js",
                                         "~/Scripts/Bs-Select2/PTCSelect2.js"));


            bundles.Add(new ScriptBundle("~/Scripts/js/Bs-Duallistbox").Include(
                                         "~/Scripts/Bs-Duallistbox/jquery.bootstrap-duallistbox.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/Bs-Treeview").Include(
                                         "~/Scripts/Bs-Treeview/jquery.unobtrusive-ajax.min.js",
                                         "~/Scripts/Bs-Treeview/bootstrap-treeview-special.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js/Sweetalert2").Include(
                                         "~/Scripts/Sweetalert2/es6-promise.auto.min.js",
                                         "~/Scripts/Sweetalert2/sweetalert2.min.js",
                                         "~/Scripts/Sweetalert2/PTCAlert.js"));


            bundles.Add(new ScriptBundle("~/Scripts/js/Global").Include(
                                         "~/Scripts/global.js",
                                         "~/Scripts/PTCGlobal.js",
                                         "~/Scripts/PTCExtend.js"));


            bundles.Add(new ScriptBundle("~/Scripts/js/Ace").Include(
                                         "~/Scripts/Ace/ace-extra.js",
                                         "~/Scripts/Ace/elements.scroller.js",
                                         "~/Scripts/Ace/elements.colorpicker.js",
                                         "~/Scripts/Ace/elements.fileinput.js",
                                         "~/Scripts/Ace/elements.typeahead.js",
                                         "~/Scripts/Ace/elements.wysiwyg.js",
                                         "~/Scripts/Ace/elements.spinner.js",
                                         "~/Scripts/Ace/elements.treeview.js",
                                         "~/Scripts/Ace/elements.wizard.js",
                                         "~/Scripts/Ace/elements.aside.js",
                                         "~/Scripts/Ace/ace.js",
                                         "~/Scripts/Ace/ace.ajax-content.js",
                                         "~/Scripts/Ace/ace.touch-drag.js",
                                         "~/Scripts/Ace/ace.sidebar.js",
                                         "~/Scripts/Ace/ace.sidebar-scroll-1.js",
                                         "~/Scripts/Ace/ace.submenu-hover.js",
                                         "~/Scripts/Ace/ace.widget-box.js",
                                         "~/Scripts/Ace/ace.settings.js",
                                         "~/Scripts/Ace/ace.settings-rtl.js",
                                         "~/Scripts/Ace/ace.settings-skin.js",
                                         "~/Scripts/Ace/ace.widget-on-reload.js",
                                         "~/Scripts/Ace/ace.searchbox-autocomplete.js",
                                         "~/Scripts/Ace/elements.onpage-help.js"));


            bundles.Add(new ScriptBundle("~/Scripts/js/Flora-Editor").Include(
                                         "~/Scripts/Flora-Editor/froala_editor.pkgd.min.js",
                                         "~/Scripts/Flora-Editor/zh_tw.js"));


            bundles.Add(new ScriptBundle("~/Scripts/js/Ace/Rainbow").Include(
                                         "~/Scripts/Ace/Rainbow/rainbow.js",
                                         "~/Scripts/Ace/Rainbow/css.js",
                                         "~/Scripts/Ace/Rainbow/generic.js",
                                         "~/Scripts/Ace/Rainbow/html.js",
                                         "~/Scripts/Ace/Rainbow/javascript.js",
                                         "~/Scripts/Ace/Rainbow/php.js"));


            BundleTable.EnableOptimizations = true;

        }
    }
}
