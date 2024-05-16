using CourseWork.Models;
using CourseWork.Persistance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork.Controllers
{
    public class TargetController
    {
        readonly ListView _targetsListView;
        public Dictionary<string, Target> Targets;

        public static event Action OnTargetsChanged;

        public TargetController(ListView targetsListView)
        {
            _targetsListView = targetsListView;
            Targets = Config.Db.Db.TargetList;

            Initialize();
        }


        public void Initialize()
        {
            OpenTabUpdate();
        }

        public void UpdateListView()
        {
            _targetsListView.Items.Clear();

            foreach(var target in Targets)
            {
                var item = new ListViewItem(target.Value.Title);
                item.Tag = target.Key;
                item.ForeColor = Color.White;

                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, target.Value.Value.ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, target.Value.MaxValue.ToString()));

                _targetsListView.Items.Add(item);
            }
        }

        public void OpenTabUpdate()
        {
            UpdateListView();
        }

        public void AddValue(string name, double value, double maxValue)
        {
            Config.Db.AddToDict<Target>(Targets, Guid.NewGuid().ToString(), new Target(name, value, maxValue));
            UpdateListView();
            OnTargetsChanged?.Invoke();
        }

        public void RemoveValue(string id)
        {
            Config.Db.RemoveFromDict<Target>(Targets, id);
            UpdateListView();
            OnTargetsChanged?.Invoke();
        }

        public void EditValue(string key, string name, double value, double maxValue)
        {
            var budjet = Config.Db.Db.TargetList[key];
            budjet.Title = name;
            budjet.Value = value;
            budjet.MaxValue = maxValue;

            Config.Db.SaveChanges();
            UpdateListView();
            OnTargetsChanged?.Invoke();
        }

        public Target GetTarget(string id)
        {
            return Targets[id];
        }
    }
}
