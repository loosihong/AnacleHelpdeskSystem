import {MDCRipple} from '@material/ripple/index';
import {MDCTextField} from '@material/textfield/index';
import {MDCSelect} from '@material/select/index';
import {MDCFormField} from '@material/form-field/index';
import {MDCRadio} from '@material/radio/index';
import {MDCCheckbox} from '@material/checkbox/index';
import {MDCDataTable} from '@material/data-table/index';
import {MDCSnackbar} from '@material/snackbar/index';
import {MDCDialog} from '@material/dialog/index';
import {MDCMenu} from '@material/menu/index';
import {MDCDrawer} from "@material/drawer/index";
import {MDCTopAppBar} from '@material/top-app-bar/index';
import {MDCTabBar} from '@material/tab-bar/index';
import {MDCTabScroller} from '@material/tab-scroller/index';

//Multiple components initialization
const ripples = [].map.call(document.querySelectorAll('.mdc-button'), function(el) {
	return new MDCRipple(el);
});
const textFields = [].map.call(document.querySelectorAll('.mdc-text-field'), function(el) {
	return new MDCTextField(el);
});
const selects = [].map.call(document.querySelectorAll('.mdc-select'), function(el) {
	return new MDCSelect(el);
});
const radios = [].map.call(document.querySelectorAll('.mdc-radio'), function(el) {
	return new MDCRadio(el);
});
const checkboxes = [].map.call(document.querySelectorAll('.mdc-checkbox'), function(el) {
	return new MDCCheckbox(el);
});
const datatables = [].map.call(document.querySelectorAll('.mdc-data-table'), function(el) {
	return new MDCDataTable(el);
});
const dialogs = [].map.call(document.querySelectorAll('.mdc-dialog'), function(el) {
	return new MDCDialog(el);
});
const menus = [].map.call(document.querySelectorAll('.mdc-menu'), function(el) {
	return new MDCMenu(el);
});
const formFields = [].map.call(document.querySelectorAll('.mdc-form-field'), function(el) {
	return new MDCFormField(el);
});

//Single component initialization
var componentEl;

componentEl = document.querySelector('.mdc-snackbar')
const snackbar = componentEl ? new MDCSnackbar(componentEl) : null;
if (snackbar) {
  snackbar.timeoutMs = -1;
}

componentEl = document.querySelector('.mdc-drawer');
const drawer = componentEl ? MDCDrawer.attachTo(componentEl) : null;

componentEl = document.querySelector('.mdc-top-app-bar');
const topAppBar = componentEl ? MDCTopAppBar.attachTo(componentEl) : null;
if (topAppBar && drawer) {
  var el = document.querySelector('.mdc-drawer-app-content');
  if (el) {
    topAppBar.setScrollTarget(el);
    topAppBar.listen('MDCTopAppBar:nav', () => {
      drawer.open = !drawer.open;
    });
  }
}

componentEl = document.querySelector('.mdc-tab-bar');
const tabBar = componentEl ? new MDCTabBar(componentEl) : null;
if (tabBar) {
  tabBar.listen('MDCTabBar:activated', (activatedEvent) => {
    var el = document.querySelectorAll('.tab');    
    tabBar.scrollintoView;
    if (el) {
      el.forEach((element, index) => {
        if (index === activatedEvent.detail.index || activatedEvent.detail.index === el.length) {
          element.classList.remove('hide');
        } else {
          element.classList.add('hide');
        }
        //Open component when tab activated
        if (activatedEvent.detail.index === 8) {
          snackbar.open();
        } if (activatedEvent.detail.index === 9) {
          if (dialogs) {
            dialogs.forEach((element, index) => {
              element.open();
            });
          }
        }
      });
    }
  });
}

componentEl = document.querySelector('.mdc-tab-scroller');
const tabScroller = componentEl ? new MDCTabScroller(componentEl) : null;

//Page load behaviour
if (tabBar) {
  tabBar.activateTab(0);
}

if (menus) {
  menus.forEach((element, index) => {
    element.open = true;
    element.setAbsolutePosition(1000, 1000);
  });
}

if (window.matchMedia("(max-width: 480px)").matches) {
  if (drawer) {
    document.querySelector('.mdc-drawer').classList.remove('mdc-drawer--open');
  }
}