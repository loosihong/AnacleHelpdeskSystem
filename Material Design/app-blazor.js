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

window.Interop = {
  AppTopBar_Init: function (element) {
    var topAppBar = MDCTopAppBar.attachTo(element);
    var drawerEl = document.querySelector('.mdc-drawer');
    
    if (drawerEl) {
      var drawer = MDCDrawer.attachTo(drawerEl);
      var drawerContentEl = document.querySelector('.mdc-drawer-app-content');
      
      topAppBar.setScrollTarget(drawerContentEl);
      topAppBar.listen('MDCTopAppBar:nav', () => {
        drawer.open = !drawer.open;
      });
      
      if (window.matchMedia("(max-width: 480px)").matches) {
        if (drawer) {
          drawerEl.classList.remove('mdc-drawer--open');
        }
      }
    }
  },
  
  TabBar_Init: function (element) {
    var tabBar = new MDCTabBar(element);
    
    /*tabBar.listen('MDCTabBar:activated', (activatedEvent) => {
      var tabs = document.querySelectorAll('.tab');
      
      if (tabs) {
        tabs.forEach((tabEl, index) => {
          if (index === activatedEvent.detail.index || activatedEvent.detail.index === tabs.length) {
            tabEl.classList.remove('hide');
          } else {
            tabEl.classList.add('hide');
          }
        });
      }
    });*/
    
    var tabScrollerEl = document.querySelector('.mdc-tab-scroller');
    var tabScroller = new MDCTabScroller(tabScrollerEl);
    
    tabBar.scrollintoView;
    tabBar.activateTab(0);
  },
  
  Button_Init: function (element) {
    new MDCRipple(element); 
  },
  
  TextField_Init: function (element) {
    new MDCTextField(element);
  },
  
  Select_Init: function (element, value) {
    var component = new MDCSelect(element);
    component.value = value; 
  },
  
  DataTable_Init: function (element) {
    var component = new MDCDataTable(element);
  },
};