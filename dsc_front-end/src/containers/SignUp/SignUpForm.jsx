import React from "react";
import styles from "./SignUpForm.module.css";

function SignUpForm() {
  return (
    <section className={styles.signUpSection}>
      <h1 className={styles.title}>Đăng ký</h1>
      <p className={styles.description}>
        Đăng ký tài khoản để truy cập vào các tính năng của chúng tôi
      </p>
      <form className={styles.form}>
        <div className={styles.formGroup}>
          <label htmlFor="email" className={styles.label}>
            Địa chỉ Email
          </label>
          <input
            type="email"
            id="email"
            className={styles.input}
            required
            aria-required="true"
          />
        </div>
        <div className={styles.formGroup}>
          <label htmlFor="password" className={styles.label}>
            Mật khẩu
          </label>
          <div className={styles.passwordWrapper}>
            <input
              type="password"
              id="password"
              className={styles.input}
              required
              aria-required="true"
              minLength="8"
            />
            <button type="button" className={styles.showPasswordButton}>
              <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/da1a62ef3ed7cff6ab291ea8a2ab7e4f2f48529c866d679ec19393f4477036c8?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="Show password" />
              <span>Hiện</span>
            </button>
          </div>
          <p className={styles.errorMessage}>Mật khẩu 8 ký tự trở lên</p>
        </div>
        <div className={styles.formGroup}>
          <label htmlFor="confirmPassword" className={styles.label}>
            Xác nhận lại mật khẩu
          </label>
          <div className={styles.passwordWrapper}>
            <input
              type="password"
              id="confirmPassword"
              className={styles.input}
              required
              aria-required="true"
            />
            <button type="button" className={styles.showPasswordButton}>
              <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/da1a62ef3ed7cff6ab291ea8a2ab7e4f2f48529c866d679ec19393f4477036c8?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="Show password" />
              <span>Hiện</span>
            </button>
          </div>
          <p className={styles.errorMessage}>Trùng khớp với mật khẩu trên</p>
        </div>
        <button type="submit" className={styles.submitButton}>
          Đăng ký
        </button>
      </form>
      <p className={styles.loginPrompt}>
        Bạn đã có tài khoản?{" "}
        <a href="/login" className={styles.loginLink}>
          Đăng nhập
        </a>
      </p>
    </section>
  );
}

export default SignUpForm;