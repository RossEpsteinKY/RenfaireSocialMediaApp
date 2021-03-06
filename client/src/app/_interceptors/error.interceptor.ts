import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {ToastrService} from "ngx-toastr";
import {NavigationExtras, Router} from "@angular/router";
import {catchError} from "rxjs/operators";
import {error} from "@angular/compiler/src/util";

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private router : Router, private toastr : ToastrService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError(error =>{
        if(error) {
          switch (error.status){
            case 400:
              if (error.error.errors) {
                throw Object.values(error.error.errors).flat();
              }
              break;
            case 401:
              this.toastr.error(error.statusText, error.status);
              break;
            case 404:
              this.router.navigateByUrl('/not-found');
              break;
            case 500:
              const navigationExtras: NavigationExtras = {state : {error: error.error}};
              this.router.navigateByUrl('/server-error',navigationExtras);
              break;
            default:
              this.toastr.error('Something unexpected has happened!');
              console.log(error);
              break;
          }
        }
        return throwError(error);
      })
    );
  }
}
