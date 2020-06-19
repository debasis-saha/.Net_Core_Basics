import { Component, OnInit, Inject } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import 'rxjs/Rx';

@Component({
  selector: 'product-add',
  templateUrl: './productadd.component.html'
})

export class productAddComponent implements OnInit {
  title: string = 'Create'
  errorMessage: any;
  modelData: any = {};
  myAppUrl: string = "";
  id: number = 0;

  constructor(private _avRoute: ActivatedRoute, public http: Http, private _router: Router, @Inject('BASE_URL') baseUrl: string) {
    debugger;
    this.myAppUrl = baseUrl;
    if (this._avRoute.snapshot.params["id"]) {
      this.id = this._avRoute.snapshot.params["id"];
    }  
  }

  ngOnInit() {
    debugger;
    if (this.id > 0) {
      this.title = "Edit";
      let self = this;
      let headers = new Headers();
      headers.append('Content-Type', 'application/json; charset=utf-8');
      this.http.get(this.myAppUrl + "api/Products/" + this.id, { headers: headers })
        .subscribe((res: Response) => {
          self.modelData = JSON.parse(res._body);
        });
    }
  }

  save(): void {
    if (this.validateData()) {
      let self = this;
      let headers = new Headers();
      headers.append('Content-Type', 'application/json; charset=utf-8');
      if (this.title == "Create") {
        this.http.post(this.myAppUrl + "api/Products", this.modelData, { headers: headers })
          .subscribe((res: Response) => {
            self._router.navigate(['/product-list']);
          });
      }
      if (this.title == "Edit") {
        this.http.put(this.myAppUrl + "api/Products/" + this.id, this.modelData, { headers: headers })
          .subscribe((res: Response) => {
            self._router.navigate(['/product-list']);
          });
      }
    }
  }

  private validateData(): boolean {
    let status: boolean = true;
    let strMessage: string = '';
    if (this.isNullOrUndefined(this.modelData)) {
      status = false;
      strMessage = 'Fill the the Fields in the Forms';
    }
    else if (this.isNullOrUndefined(this.modelData.productCode)) {
      status = false;
      strMessage = 'Provide Product Code Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.productName)) {
      status = false;
      strMessage = 'Provide Product Name Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.manufacturer)) {
      status = false;
      strMessage = 'Provide Manufacturer details Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.shippingNo)) {
      status = false;
      strMessage = 'Provide Shipping No Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.serialNo)) {
      status = false;
      strMessage = 'Provide Serial No Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.batchNo)) {
      status = false;
      strMessage = 'Provide Batch No Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.mrp)) {
      status = false;
      strMessage = 'Provide Retial Price Properly...';
    }
    else if (this.isNullOrUndefined(this.modelData.quantity)) {
      status = false;
      strMessage = 'Provide Quantity Properly...';
    }
    if (status === false)
      alert(strMessage);
    return status;
  }

  isNullOrUndefined(data: any): boolean {
    return this.isUndefined(data) || this.isNull(data);
  }

  isUndefined(data: any): boolean {
    return typeof (data) === "undefined";
  }

  isNull(data: any): boolean {
    return data === null;
  }
  
  cancel() {
    this._router.navigate(['/product-list']);
  }

} 
