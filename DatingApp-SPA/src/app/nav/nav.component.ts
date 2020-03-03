import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  // this will store our username and password
  model: any  = {};

  constructor(public authService: AuthService, private alertify: AlertifyService, private router: Router) { }

  ngOnInit() {
  }

  login(){
    this.authService.login(this.model).subscribe(next => {
      console.log('Logueado correctamente');
      this.alertify.success('Logueado bien');
    }, error => {
      console.log(error);
      this.alertify.error(error);
    }, () => {
      this.router.navigate(['/messages']);
    });
  }

  loggedIn() {
    // const token = localStorage.getItem('token');

    // return !!token; // if this token variable is empty then it's going to return false

    return this.authService.loggedIn();
  }

  loggedOut() {
    localStorage.removeItem('token');
    this.alertify.message('logged out');
    this.router.navigate(['/home'])
  }

}
