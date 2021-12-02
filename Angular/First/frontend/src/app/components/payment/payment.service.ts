import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Observable } from "rxjs";
import { Payment } from "./payment.model";

@Injectable({
  providedIn: "root",
})
export class PaymentService {
  baseUrl = "http://localhost:3001/notaFiscal";
  constructor(private snackBar: MatSnackBar, private http: HttpClient) {}

  showMessage(msg: string, isError: boolean = false): void {
    this.snackBar.open(msg, "X", {
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top",
      panelClass: isError ? ["msg-error"] : ["msg-success"],
    });
  }

  create(payment: Payment): Observable<Payment> {
    return this.http.post<Payment>(this.baseUrl, payment);
  }

  read(): Observable<Payment[]> {
    return this.http.get<Payment[]>(this.baseUrl);
  }

  readById(id: number): Observable<Payment> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.get<Payment>(url);
  }

  update(payment: Payment): Observable<Payment> {
    const url = `${this.baseUrl}/${payment.id}`;
    return this.http.put<Payment>(url, payment);
  }

  delete(id: number): Observable<Payment> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.delete<Payment>(url);
  }
}
