using sortstring.Models;
using sortstring.Views;
using sortstring.Formula;
using System;
using System.Reflection;

namespace sortstring.Controllers
{
    public class MainController
    {
        private SortModel _model;
        private Sortstring _view;

        public MainController(SortModel model, Sortstring view)
        {
            _model = model;
            _view = view;

            _view.Load += onload;
            _view.SortComboBox.SelectedIndexChanged += onchange_ComboBox;
            _view.SortButton.Click += onclick_Sort;
        }

        private void onload(object sender, EventArgs e)
        {
            _view.SortComboBox.Items.AddRange(_model.Sortoption.ToArray());
            _view.SortComboBox.SelectedItem = _model.Sort;
            _view.InputTextBox.Text = _model.Input;
            _view.OutputLabel.Text = _model.Output;
        }

        private void onchange_ComboBox(object sender, EventArgs e)
        {
            // Update model when ComboBox selection changes
            _model.Sort = _view.SortComboBox.SelectedItem?.ToString();
        }

        private void onclick_Sort(object sender, EventArgs e)
        {
            _model.Input = _view.InputTextBox.Text;

            try
            {
                switch (_model.Sort)
                {
                    case "Bubble Sort":
                        _model.Output = Sort.BubbleSort(_model.Input);
                        break;
                    case "Quick Sort":
                        _model.Output = Sort.QuickSort(_model.Input);
                        break;
                    /*
                    case "Merge Sort":
                        _model.Output = Sort.MergeSort(_model.Input);
                        break;
                    */
                    default:
                        _model.Output = "Invalid sort option.";
                        break;
                }
            }
            catch (Exception ex)
            {
                _model.Output = $"Error: {ex.Message}";
            }

            _view.OutputLabel.Text = _model.Output;
        }
    }
}
