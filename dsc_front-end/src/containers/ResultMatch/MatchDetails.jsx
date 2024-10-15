import React from "react";
import styles from './MatchDetails.module.css';

function MatchDetails() {
  return (
    <section className={styles.matchDetails}>
      <h1 className={styles.matchTitle}>Pickleball Match</h1>
      <div className={styles.matchInfo}>
        <div className={styles.infoItem}>
          <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/6a4b5a0eddec96f9735cdb5d7db770a1698166c27664b7ebed9da4cbd4d589bd?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="" className={styles.infoIcon} />
          <span>Tất cả trình độ</span>
        </div>
        <div className={styles.infoItem}>
          <img src="https://cdn.builder.io/api/v1/image/assets/TEMP/a37b2e1b41f74422366e59f725b4a4a78cf3b432e93f670bcbb053b5b9674fe1?placeholderIfAbsent=true&apiKey=64a11f7ccf9c4f09a01cd9aadc1c5dac" alt="" className={styles.infoIcon} />
          <span>Sân bóng rổ</span>
        </div>
      </div>
      <p className={styles.participants}>Số người tham gia: 5/12</p>
      <p className={styles.price}>$ 30,000đ</p>
    </section>
  );
}

export default MatchDetails;